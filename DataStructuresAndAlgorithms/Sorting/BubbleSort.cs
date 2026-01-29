using DataStructuresAndAlgorithms.Helpers;

namespace DataStructuresAndAlgorithms.Sorting;

public class BubbleSort
{
    public static int[] Sort(int[] nums, bool ascending = true)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (ascending ? nums[i] > nums[j] : nums[j] > nums[i])
                {
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                }
            }
        }

        return nums;
    }
    
    public static void RunTest()
    {
        int[] nums = [10, 9, 8 ,7, 6, 5, 4, 3, 2, 1];
        int[] nums2 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        ArrayHelper.PrintArray(Sort(nums), "Sorted array ascendic");
        ArrayHelper.PrintArray(Sort(nums2, false), "Sorted array descendic");
        
    }
}