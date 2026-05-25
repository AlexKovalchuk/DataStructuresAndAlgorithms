namespace DataStructuresAndAlgorithms.Arrays;
/*
 34. Find First and Last Position of Element in Sorted Array
 
   Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.
   
   If target is not found in the array, return [-1, -1].
   
   You must write an algorithm with O(log n) runtime complexity.
   
   Example 1:
   
   Input: nums = [5,7,7,8,8,10], target = 8
   Output: [3,4]
   Example 2:
   
   Input: nums = [5,7,7,8,8,10], target = 6
   Output: [-1,-1]
   Example 3:
   
   Input: nums = [], target = 0
   Output: [-1,-1]
*/
public class FindFirstAndLastPositionOfElementsInSortedArray_34
{
    public int LowerBound(int[] nums, int target)
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
    
    public static int UpperBound(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] > target)
                right = mid - 1;
            else
                left = mid + 1;
        }

        return left;
    }
    
    public int[] SearchRange(int[] nums, int target)
    {
        int[] result = new int[]{-1, -1};
        int targetLeft = LowerBound(nums, target);
        if (targetLeft < nums.Length && nums[targetLeft] == target)
        {
            result[0] = targetLeft;
            result[1] = UpperBound(nums, target) - 1;
        }
        return result;
    }
}