using static AiSD_101.Algorithms.Sorting.Helpers;

namespace AiSD_101.Algorithms.Sorting;

public class MergeSort<T> : ISortingAlgorithm<T> where T : IComparable<T>
{
    private MergeSort() { }

    public static Lazy<MergeSort<T>> Instance => new (() => new MergeSort<T>());

    public void Sort(T[] array)
    {
        SortImpl(array, 0, array.Length - 1);
    }

    private void SortImpl(T[] array, int left, int right)
    {
        if (left >= right) return;
        
        var middle = (left + right) / 2;

        SortImpl(array, left, middle);
        SortImpl(array, middle + 1, right);

        Merge(array, left, middle, right);
    }

    private void Merge(T[] array, int left, int middle, int right)
    {
        // Find sizes of two
        // subarrays to be merged
        var temp = new T[right - left + 1];

        // crawlers for both intervals and for temp
        int i = left, j = middle + 1, k = 0;

        // traverse both arrays and in each iteration add smaller of both elements in temp 
        while (i <= middle && j <= right)
        {
            if (array[i].CompareTo(array[j]) < 0)
            {
                temp[k] = array[i];
                k += 1;
                i += 1;
            }
            else
            {
                temp[k] = array[j];
                k += 1;
                j += 1;
            }
        }

        // add elements left in the first interval 
        while (i <= middle)
        {
            temp[k] = array[i];
            k += 1;
            i += 1;
        }

        // add elements left in the second interval 
        while (j <= right)
        {
            temp[k] = array[j];
            k += 1;
            j += 1;
        }

        // copy temp to original interval
        for (i = left; i <= right; i += 1)
        {
            array[i] = temp[i - left];
        }
    }
}

    