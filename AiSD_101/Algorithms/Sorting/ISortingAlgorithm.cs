namespace AiSD_101.Algorithms.Sorting;

public interface ISortingAlgorithm<in T> where T : IComparable<T>
{
    public void Sort(T[] array);
}