using AiSD_101.Algorithms.Sorting;

namespace AiSD_101;

using static Helpers;

public static class Generators
{
    private static readonly Random Random = new ();
    public static int[] GenerateRandom(int size, int minVal, int maxVal)
    {
        return Enumerable.Range(0, size).Select(_ => Random.Next(minVal, maxVal)).ToArray();
    }

    public static int[] GenerateSorted(int size, int minVal, int maxVal)
    {
        var array = GenerateRandom(size, minVal, maxVal);
        Array.Sort(array);
        return array;
    }
    
    public static int[] GenerateReversed(int size, int minVal, int maxVal)
    {
        var array = GenerateSorted(size, minVal, maxVal);
        Array.Reverse(array);
        return array;
    }

    public static int[] GenerateAlmostSorted(int size, int minVal, int maxVal, int percentOutOfOrder)
    {
        var array = GenerateSorted(size, minVal, maxVal);

        for (var i = 0; i < percentOutOfOrder * size / 100; i++)
        {
            int idxFrom, idxTo;
            
            do
            {
                idxFrom = Random.Next(0, array.Length - 1);
                idxTo = Random.Next(0, array.Length - 1);
            } while (idxFrom != idxTo);
            
            Swap(array, idxTo, idxFrom);
        }

        return array;
    }
}