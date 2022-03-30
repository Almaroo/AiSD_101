using static AiSD_101.Algorithms.Sorting.Helpers;

namespace AiSD_101.Algorithms.Sorting;

public class InsertionSort<T> : ISortingAlgorithm<T> where T : IComparable<T>
{
    private InsertionSort() { }

    public static Lazy<InsertionSort<T>> Instance => new(() => new InsertionSort<T>());
    
    public void Sort(T[] array)
    {
        SortImpl(array);
    }

    private void SortImpl(T[] array)
    {
        for (var i = 1; i < array.Length; i++)
        {
            var j = i;
            while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
            {
                Swap(array, j, j - 1);
                j--;
            }
        }
    }
}