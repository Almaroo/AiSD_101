// See https://aka.ms/new-console-template for more information

using AiSD_101;
using AiSD_101.Algorithms.Sorting;

const int small = 1_000;
const int medium = 10_000;
const int large = 100_000;


var insertionSort = SortingAlgorithms.Insertion<int>();
var mergeSort = SortingAlgorithms.Merge<int>();
var quickSort = SortingAlgorithms.Quick<int>();

Benchmark.GetSortingStatistics(
    $"Przypadek 1: próba mała (n = {small:N0}), random",
    () => Generators.GenerateRandom(small, 0, 100),
    new List<(string name, Action<int[]> action)>
    {
        (nameof(InsertionSort<int>), (values) =>
        {
            insertionSort.Sort(values);
        }),
        (nameof(MergeSort<int>), (values) =>
        {
            mergeSort.Sort(values);
        }),
        (nameof(QuickSort<int>), (values) =>
        {
            quickSort.Sort(values);
        }),
        ("Array.Sort", Array.Sort)
    });

Benchmark.GetSortingStatistics(
    $"Przypadek 2: próba mała (n = {small:N0}), sorted",
    () => Generators.GenerateSorted(small, 0, 100),
    new List<(string name, Action<int[]> action)>
    {
        (nameof(InsertionSort<int>), (values) =>
        {
            insertionSort.Sort(values);
        }),
        (nameof(MergeSort<int>), (values) =>
        {
            mergeSort.Sort(values);
        }),
        (nameof(QuickSort<int>), (values) =>
        {
            quickSort.Sort(values);
        }),
        ("Array.Sort", Array.Sort)
    });
    
Benchmark.GetSortingStatistics(
    $"Przypadek 3: próba mała (n = {small:N0}), reversed",
    () => Generators.GenerateReversed(small, 0, 100),
    new List<(string name, Action<int[]> action)>
    {
        (nameof(InsertionSort<int>), (values) =>
        {
            insertionSort.Sort(values);
        }),
        (nameof(MergeSort<int>), (values) =>
        {
            mergeSort.Sort(values);
        }),
        (nameof(QuickSort<int>), (values) =>
        {
            quickSort.Sort(values);
        }),
        ("Array.Sort", Array.Sort)
    });
    
Benchmark.GetSortingStatistics(
    $"Przypadek 4: próba mała (n = {small:N0}), almost sorted",
    () => Generators.GenerateAlmostSorted(small, 0, 100, 10),
    new List<(string name, Action<int[]> action)>
    {
        (nameof(InsertionSort<int>), (values) =>
        {
            insertionSort.Sort(values);
        }),
        (nameof(MergeSort<int>), (values) =>
        {
            mergeSort.Sort(values);
        }),
        (nameof(QuickSort<int>), (values) =>
        {
            quickSort.Sort(values);
        }),
        ("Array.Sort", Array.Sort)
    });
    
Benchmark.GetSortingStatistics(
    $"Przypadek 5: próba mała (n = {small:N0}), few unique",
    () => Generators.GenerateRandom(small, 0, 5),
    new List<(string name, Action<int[]> action)>
    {
        (nameof(InsertionSort<int>), (values) =>
        {
            insertionSort.Sort(values);
        }),
        (nameof(MergeSort<int>), (values) =>
        {
            mergeSort.Sort(values);
        }),
        (nameof(QuickSort<int>), (values) =>
        {
            quickSort.Sort(values);
        }),
        ("Array.Sort", Array.Sort)
    });
    
Benchmark.GetSortingStatistics(
    $"Przypadek 6: próba średnia (n = {medium:N0}), random",
    () => Generators.GenerateRandom(medium, 0, medium),
    new List<(string name, Action<int[]> action)>
    {
        (nameof(InsertionSort<int>), (values) =>
        {
            insertionSort.Sort(values);
        }),
        (nameof(MergeSort<int>), (values) =>
        {
            mergeSort.Sort(values);
        }),
        (nameof(QuickSort<int>), (values) =>
        {
            quickSort.Sort(values);
        }),
        ("Array.Sort", Array.Sort)
    });

Benchmark.GetSortingStatistics(
    $"Przypadek 7: próba średnia (n = {medium:N0}), sorted",
    () => Generators.GenerateSorted(medium, 0, medium),
    new List<(string name, Action<int[]> action)>
    {
        (nameof(InsertionSort<int>), (values) =>
        {
            insertionSort.Sort(values);
        }),
        (nameof(MergeSort<int>), (values) =>
        {
            mergeSort.Sort(values);
        }),
        (nameof(QuickSort<int>), (values) =>
        {
            quickSort.Sort(values);
        }),
        ("Array.Sort", Array.Sort)
    });
    
Benchmark.GetSortingStatistics(
    $"Przypadek 8: próba średnia (n = {medium:N0}), reversed",
    () => Generators.GenerateReversed(medium, 0, medium),
    new List<(string name, Action<int[]> action)>
    {
        (nameof(InsertionSort<int>), (values) =>
        {
            insertionSort.Sort(values);
        }),
        (nameof(MergeSort<int>), (values) =>
        {
            mergeSort.Sort(values);
        }),
        (nameof(QuickSort<int>), (values) =>
        {
            quickSort.Sort(values);
        }),
        ("Array.Sort", Array.Sort)
    });
    
Benchmark.GetSortingStatistics(
    $"Przypadek 9: próba średnia (n = {medium:N0}), almost sorted",
    () => Generators.GenerateAlmostSorted(medium, 0, 100, 10),
    new List<(string name, Action<int[]> action)>
    {
        (nameof(InsertionSort<int>), (values) =>
        {
            insertionSort.Sort(values);
        }),
        (nameof(MergeSort<int>), (values) =>
        {
            mergeSort.Sort(values);
        }),
        (nameof(QuickSort<int>), (values) =>
        {
            quickSort.Sort(values);
        }),
        ("Array.Sort", Array.Sort)
    });
    
Benchmark.GetSortingStatistics(
    $"Przypadek 10: próba średnia (n = {medium:N0}), few unique",
    () => Generators.GenerateRandom(medium, 0, 5),
    new List<(string name, Action<int[]> action)>
    {
        (nameof(InsertionSort<int>), (values) =>
        {
            insertionSort.Sort(values);
        }),
        (nameof(MergeSort<int>), (values) =>
        {
            mergeSort.Sort(values);
        }),
        (nameof(QuickSort<int>), (values) =>
        {
            quickSort.Sort(values);
        }),
        ("Array.Sort", Array.Sort)
    });
    
Benchmark.GetSortingStatistics(
    $"Przypadek 11: próba duża (n = {large:N0}), random",
    () => Generators.GenerateRandom(large, 0, large),
    new List<(string name, Action<int[]> action)>
    {
        (nameof(InsertionSort<int>), (values) =>
        {
            insertionSort.Sort(values);
        }),
        (nameof(MergeSort<int>), (values) =>
        {
            mergeSort.Sort(values);
        }),
        (nameof(QuickSort<int>), (values) =>
        {
            quickSort.Sort(values);
        }),
        ("Array.Sort", Array.Sort)
    });

Benchmark.GetSortingStatistics(
    $"Przypadek 12: próba duża (n = {large:N0}), sorted",
    () => Generators.GenerateSorted(large, 0, large),
    new List<(string name, Action<int[]> action)>
    {
        (nameof(InsertionSort<int>), (values) =>
        {
            insertionSort.Sort(values);
        }),
        (nameof(MergeSort<int>), (values) =>
        {
            mergeSort.Sort(values);
        }),
        (nameof(QuickSort<int>), (values) =>
        {
            quickSort.Sort(values);
        }),
        ("Array.Sort", Array.Sort)
    });
    
Benchmark.GetSortingStatistics(
    $"Przypadek 13: próba duża (n = {large:N0}), reversed",
    () => Generators.GenerateReversed(large, 0, large),
    new List<(string name, Action<int[]> action)>
    {
        (nameof(InsertionSort<int>), (values) =>
        {
            insertionSort.Sort(values);
        }),
        (nameof(MergeSort<int>), (values) =>
        {
            mergeSort.Sort(values);
        }),
        (nameof(QuickSort<int>), (values) =>
        {
            quickSort.Sort(values);
        }),
        ("Array.Sort", Array.Sort)
    });
    
Benchmark.GetSortingStatistics(
    $"Przypadek 14: próba duża (n = {large:N0}), almost sorted",
    () => Generators.GenerateAlmostSorted(large, 0, 100, 10),
    new List<(string name, Action<int[]> action)>
    {
        (nameof(InsertionSort<int>), (values) =>
        {
            insertionSort.Sort(values);
        }),
        (nameof(MergeSort<int>), (values) =>
        {
            mergeSort.Sort(values);
        }),
        (nameof(QuickSort<int>), (values) =>
        {
            quickSort.Sort(values);
        }),
        ("Array.Sort", Array.Sort)
    });
    
Benchmark.GetSortingStatistics(
    $"Przypadek 15: próba duża (n = {large:N0}), few unique",
    () => Generators.GenerateRandom(large, 0, 5),
    new List<(string name, Action<int[]> action)>
    {
        (nameof(InsertionSort<int>), (values) =>
        {
            insertionSort.Sort(values);
        }),
        (nameof(MergeSort<int>), (values) =>
        {
            mergeSort.Sort(values);
        }),
        (nameof(QuickSort<int>), (values) =>
        {
            quickSort.Sort(values);
        }),
        ("Array.Sort", Array.Sort)
    });