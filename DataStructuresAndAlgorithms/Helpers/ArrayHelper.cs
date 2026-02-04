namespace DataStructuresAndAlgorithms.Helpers;

public static class ArrayHelper
{
    public static void PrintArray(int[] array, string title)
    {
        var length = array.Length;
        Console.WriteLine(title);
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(array[i] + " ");
        }
    }
}