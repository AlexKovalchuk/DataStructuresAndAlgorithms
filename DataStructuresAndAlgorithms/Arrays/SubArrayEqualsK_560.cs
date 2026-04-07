namespace DataStructuresAndAlgorithms.Arrays;

/*
   560. Subarray Sum Equals K
   Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.
   A subarray is a contiguous non-empty sequence of elements within an array.
   
   Example 1:
   Input: nums = [1,1,1], k = 2
   Output: 2
   
   Example 2:
   Input: nums = [1,2,3], k = 3
   Output: 2
 */

/*
   взяв num
   оновив currentPrefixSum
   пошукав neededPrefix
   оновив map
 */

public class SubArrayEqualsK_560
{
    public int SubarraySum(int[] nums, int k)
    {
        var map = new Dictionary<int, int>();
        var count = 0;
        var currentPrefixSum = 0;
        map[0] = 1;
        foreach (var num in nums)
        {
            currentPrefixSum += num;
            int neededPrefix = currentPrefixSum - k;
            if (map.TryGetValue(neededPrefix, out var value)) count += value;
            if (!map.TryAdd(currentPrefixSum, 1)) map[currentPrefixSum]++;
        }

        return count;
    }
}