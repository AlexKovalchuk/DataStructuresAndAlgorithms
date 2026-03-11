namespace DataStructuresAndAlgorithms.Arrays;

/* 485. Max Consecutive Ones
 * Given a binary array nums, return the maximum number of consecutive 1's in the array.
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
}