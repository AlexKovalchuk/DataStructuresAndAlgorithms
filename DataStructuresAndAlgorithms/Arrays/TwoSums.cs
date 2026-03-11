namespace DSA.arrays;

/*
    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.  
    You can return the answer in any order.
    Example:
    Input: nums = [3,2,4], target = 6
    Output: [1,2]
*/
public static class TwoSums
{
    public static int[] TwoSumSimple(int[] nums, int target)
    {
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
            }
        }
        return result;
    }

    public static int[] TwoSumOptimized(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(target - nums[i]))
            {
                return [i, map[target - nums[i]]];
            }
            map.TryAdd(nums[i], i);
        }
        
        return [];
    }
}