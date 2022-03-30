namespace AiSD_101.Algorithms.Sorting;

public static class SortingAlgorithms
{
    public static ISortingAlgorithm<T> Insertion<T>() where T : IComparable<T> =>
        InsertionSort<T>.Instance.Value;
    
    public static ISortingAlgorithm<T> Merge<T>() where T : IComparable<T> => 
        MergeSort<T>.Instance.Value;

    public static ISortingAlgorithm<T> Quick<T>() where T : IComparable<T> =>
        QuickSort<T>.Instance.Value;
}