using System.Diagnostics;

namespace AiSD_101;

public static class Benchmark
{
    private static readonly Stopwatch Stopwatch = new();

    public static void GetSortingStatistics<T>(string description, Func<IEnumerable<T>> initialize,
        IEnumerable<(string name, Action<T[]> action)> variants, int repeatTimes = 10)
        where T : IComparable<T>
    {
        Console.WriteLine(description);

        var array = initialize().ToArray();
        
        foreach (var variant in variants)
        {
            Console.Write($"* {variant.name}: ");
            var times = MeasureTime(variant.action, array, repeatTimes);

            var average = times.Average(x => x.TotalSeconds);
            var stDev = CalculateStdDeviation(times.Select(x => x.TotalSeconds));
            
            Console.WriteLine($"t = {average:F4} +/- {stDev:F4}");
        }

        Console.WriteLine();
    }

    private static TimeSpan[] MeasureTime<T>(Action<T[]> variantAction, T[] array, int repeatTimes) where T : IComparable<T>
    {
        var timeResults = new TimeSpan[repeatTimes];
        for (var i = 0; i < repeatTimes; i++)
        {
            Stopwatch.Restart();
            variantAction((T[])array.Clone());
            Stopwatch.Stop();

            timeResults[i] = Stopwatch.Elapsed;
        }

        return timeResults;
    }

    private static double CalculateStdDeviation(IEnumerable<double> values)
    {
        var result = 0d;

        var enumerable = values.ToList();

        if (!enumerable.Any()) return result;
        
        var avg = enumerable.Average();
        double sum = enumerable.Sum(d => Math.Pow(d - avg, 2));
        result = Math.Sqrt((sum) / enumerable.Count());

        return result;
    }
}