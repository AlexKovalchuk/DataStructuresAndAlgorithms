namespace DSA.arrays;

/*
   Given an integer array nums sorted in non-decreasing order,
   remove the duplicates in-place such that each unique element appears only once.
   The relative order of the elements should be kept the same.
   Consider the number of unique elements in nums to be k. 
   After removing duplicates, return the number of unique elements k.
   The first k elements of nums should contain the unique numbers in sorted order. 
   The remaining elements beyond index k - 1 can be ignored.
 */

public static class RemoveDuplicatesFromSortedArray
{
    public static int RemoveDuplicatesSimple(int[] nums)
    {
        if (nums.Length == 0) return 0;
        int k = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if ( nums[i] != nums[i-1])
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }

    public static void RunTests()
    {
        Console.WriteLine("============================");
        Console.WriteLine("Remove Duplicates from Sorted Array:");
        int[] nums = {0,0,1,1,1,2,2,3,3,4};
        //           {0,1,1,1,1,2,2,3,3,4};
        int uniqueCount = RemoveDuplicatesSimple(nums);
        Console.WriteLine("Unique count is: {0}", uniqueCount);
        for (int i = 0; i < uniqueCount; i++)
        {
            Console.WriteLine(nums[i]);

        }
    }
}