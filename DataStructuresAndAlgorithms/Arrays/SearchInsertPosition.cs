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

public static class SearchInsertPosition
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
}