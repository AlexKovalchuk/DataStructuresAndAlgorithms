namespace DataStructuresAndAlgorithms.arrays;

/*
 * Find the Duplicate Number in an Array
 */

public static class FindDuplicate
{
    public static bool FindDuplicateSimple(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int value = nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (value == nums[j])
                {
                    return true;
                }
            }
        }
        
        return false;
    }

    public static bool FindDuplicateHashSet(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (var n in nums)
        {
            if (set.Contains(n))
            {
                return true;
            }
            set.Add(n);
        }
        return false;
    }
}