namespace DataStructuresAndAlgorithms.Arrays;

// 35. Search Insert Position
/*
 * Given a sorted array of distinct integers and a target value, return the index if the target is found.
   If not, return the index where it would be if it were inserted in order.
   You must write an algorithm with O(log n) runtime complexity.
   Example 1:
   
   Input: nums = [1,3,5,6], target = 5
   Output: 2
   Example 2:
   
   Input: nums = [1,3,5,6], target = 2
   Output: 1
   Example 3:
   
   Input: nums = [1,3,5,6], target = 7
   Output: 4

   Constraints:
   
   1 <= nums.length <= 104
   -104 <= nums[i] <= 104
   nums contains distinct values sorted in ascending order.
   -104 <= target <= 104
 */

public class SearchInsertPosition
{
    public static int SearchInsertBruteForce(int[] nums, int target)
    {
        int length = nums.Length;
        int result = length;
        for (int i = 0; i < length; i++)
        {
            if (target == nums[i])
            {
                return i;
            }

            if (nums[i] > target)
            {
                result = i;
                break;
            }
        }
        
        return result;
    }

    public static int SearchInsertUsingBinarySearch(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] >= target)
                right = mid - 1;
            else
                left = mid + 1;
        }

        return left;
    }
    
    public static void RunTest()
    {
        Console.WriteLine("Use brute force search:");
        int[] nums = [1, 3, 5, 6];
        int target = 5;
        int expected = 2;
        int result = SearchInsertBruteForce(nums, target);
        Console.WriteLine($"Expected: {expected}, actual result: {result}");
        
        int[] nums2 = [1, 3, 5, 6];
        int target2 = 2;
        int expected2 = 1;
        int result2 = SearchInsertBruteForce(nums2, target2);
        Console.WriteLine($"Expected: {expected2}, actual result: {result2}");
        
        int[] nums3 = [1, 3, 5, 6];
        int target3 = 7;
        int expected3 = 4;
        int result3 = SearchInsertBruteForce(nums3, target3);
        Console.WriteLine($"Expected: {expected3}, actual result: {result3}");
        
        Console.WriteLine("Use Binary search:");
        
        int[] nums4 = [1, 3, 5, 6];
        int target4 = 5;
        int expected4 = 2;
        int result4 = SearchInsertUsingBinarySearch(nums4, target4);
        Console.WriteLine($"Expected: {expected4}, actual result: {result4}");
        
        int[] nums5 = [1, 3, 5, 6];
        int target5 = 2;
        int expected5 = 1;
        int result5 = SearchInsertBruteForce(nums5, target5);
        Console.WriteLine($"Expected: {expected5}, actual result: {result5}");
        
        int[] nums6 = [1, 3, 5, 6];
        int target6 = 7;
        int expected6 = 4;
        int result6 = SearchInsertBruteForce(nums6, target6);
        Console.WriteLine($"Expected: {expected6}, actual result: {result6}");
    }
}