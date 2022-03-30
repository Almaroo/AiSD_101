namespace AiSD_101.Algorithms.Sorting;

using static Helpers;

public class QuickSort<T> : ISortingAlgorithm<T> where T : IComparable<T>
{
    private QuickSort() {}

    public static Lazy<QuickSort<T>> Instance => new(() => new QuickSort<T>());

    public void Sort(T[] array)
    {
        SortImpl(array, 0, array.Length - 1);
    }

    private void SortImpl(T[] array, int lower, int upper)
    {
        if(lower >= upper) return;

        var (begin, end) = Partition(array, lower, upper);
        SortImpl(array, lower, begin - 1);
        SortImpl(array, end + 1, upper);
    }

    private (int begin, int end) Partition(T[] array, int lower, int upper)
    {
        var begin = lower;
        var i = lower;
        var end = upper;
        var pivot = array[(lower + upper) / 2];

        while (i <= end)
        {
            if (array[i].CompareTo(pivot) < 0)
            {
                Swap(array, i, begin);
                begin++;
                i++;
            }
            else if(array[i].CompareTo(pivot) > 0)
            {
                Swap(array, i, end);
                end--;
            }
            else
            {
                i++;
            }
        }

        return (begin, end);
    }
}