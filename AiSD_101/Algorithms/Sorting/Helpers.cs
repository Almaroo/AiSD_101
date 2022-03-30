namespace AiSD_101.Algorithms.Sorting;

public static class Helpers
{
    public static void Swap<T>(T[] array, int first, int second) => (array[first], array[second]) = (array[second], array[first]);
}