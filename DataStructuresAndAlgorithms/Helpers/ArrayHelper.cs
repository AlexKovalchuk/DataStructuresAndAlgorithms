namespace DataStructuresAndAlgorithms.Helpers;

public static class ArrayHelper
{
    public static void PrintArray(int[] array, string title)
    {
        var length = array.Length;
        Console.WriteLine(title);
        for (int i = 0; i < length; i++)
        {
            Console.Write($"{array[i]}{(i == length - 1 ? "." : ", ")}");
        }
        Console.WriteLine();
    }
}