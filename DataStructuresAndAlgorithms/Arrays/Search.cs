namespace DataStructuresAndAlgorithms.Arrays;


/* 704. Binary Search
 * Given an array of integers nums which is sorted in ascending order,
 * and an integer target, write a function to search target in nums.
 * If target exists, then return its index. Otherwise, return -1.
   You must write an algorithm with O(log n) runtime complexity.
   
   Example 1:
   
   Input: nums = [-1,0,3,5,9,12], target = 9
   Output: 4
   Explanation: 9 exists in nums and its index is 4
   Example 2:
   
   Input: nums = [-1,0,3,5,9,12], target = 2
   Output: -1
   Explanation: 2 does not exist in nums so return -1
    
   
   Constraints:
   
   1 <= nums.length <= 104
   -104 < nums[i], target < 104
   All the integers in nums are unique.
   nums is sorted in ascending order.
 */

public class Search
{
    public static int BinarySearch(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target) {
                return mid;
            }
            if (nums[mid] > target)
                right = mid - 1;
            else
                left = mid + 1;
        }

        return -1;
    }

    public static void RunTests()
    {
        int [] nums = new int[]{-1,0,3,5,9,12};
        var result = BinarySearch(nums, 9);
        Console.WriteLine($"Expected result: 4, Actual result: {result}");
        var result2 = BinarySearch(nums, 2);
        Console.WriteLine($"Expected result: -1, Actual result: {result2}");
    }
}