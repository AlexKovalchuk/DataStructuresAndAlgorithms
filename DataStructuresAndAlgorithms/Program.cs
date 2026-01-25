using DataStructuresAndAlgorithms.arrays;

namespace DataStructuresAndAlgorithms;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Data Structures and Algorithms!");
        
        // FindDuplicate.RunTests();
        // TwoSums.RunTests();
        // LongestCommonPrefix.RunTests();
        // RemoveDuplicatesFromSortedArray.RunTests();
        RemoveElement.RunTests();
        RemoveElement.BubbleSort([5,1,4,2], true);
    }
}