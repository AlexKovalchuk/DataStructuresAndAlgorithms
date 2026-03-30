namespace DataStructuresAndAlgorithms.Arrays;

/*
   485. Max Consecutive Ones
   Given a binary array nums, return the maximum number of consecutive 1's in the array.
   
   Example 1:
   Input: nums = [1,1,0,1,1,1]
   Output: 3
   Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
   Example 2:
   
   Input: nums = [1,0,1,1,0,1]
   Output: 2
   
 */

public static class MaxConsecutiveOnes485
{
    public static int FindMaxConsecutiveOnes(int[] nums)
    {
        int maxCount = 0;
        int currCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                currCount++;
            }
            else
            {
                currCount = 0;
            }
            maxCount = Math.Max(currCount, maxCount);
        }

        return maxCount;
    }

    public static int FindMaxConsecutiveOnes_SlidingWindows(int[] nums)
    {
        int maxCount = 0;
        int left = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            if(nums[right] != 1)
            {
                left = right + 1;
            }
            maxCount = Math.Max(maxCount, right - left + 1);
        }
        
        return maxCount;
    }
}