namespace DataStructuresAndAlgorithms.Arrays;

/* 3 Sum
 * Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
   
   Notice that the solution set must not contain duplicate triplets.
   
    
   
   Example 1:
   
   Input: nums = [-1,0,1,2,-1,-4]
   Output: [[-1,-1,2],[-1,0,1]]
   Explanation: 
   nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
   nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
   nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
   The distinct triplets are [-1,0,1] and [-1,-1,2].
   Notice that the order of the output and the order of the triplets does not matter.
   Example 2:
   
   Input: nums = [0,1,1]
   Output: []
   Explanation: The only possible triplet does not sum up to 0.
   Example 3:
   
   Input: nums = [0,0,0]
   Output: [[0,0,0]]
   Explanation: The only possible triplet sums up to 0.
 */

public class ThreeSum_15
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums); 
        var result = new List<IList<int>>();
        int maxLength = nums.Length - 2;

        for (int i = 0; i < maxLength; i++)
        {
            int current = nums[i];
            if (current > 0) break;
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                var sum = current + nums[left] + nums[right];
                if(sum < 0)
                {
                    left++;
                    continue;
                }
                if(sum > 0)
                {
                    right--;
                    continue;
                }

                var currResult = new List<int>{ current, nums[left], nums[right] };
                result.Add(currResult);
                int curLeft = left;
                int curRight = right;
                while (left < right &&  nums[left] == nums[curLeft])
                {
                    left++;
                }
                while (right > left && nums[right] == nums[curRight])
                {
                    right--;
                }
            }
        }
        
        return result;
    }
}