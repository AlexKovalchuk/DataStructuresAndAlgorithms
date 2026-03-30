namespace DataStructuresAndAlgorithms.Arrays;

/* 303. Range Sum Query - Immutable
 * Given an integer array nums, handle multiple queries of the following type:
   
   Calculate the sum of the elements of nums between indices left and right inclusive where left <= right.
   Implement the NumArray class:
   
   NumArray(int[] nums) Initializes the object with the integer array nums.
   int sumRange(int left, int right) Returns the sum of the elements of nums between indices left and right inclusive (i.e. nums[left] + nums[left + 1] + ... + nums[right]).
    
   
   Example 1:
   
   Input
   ["NumArray", "sumRange", "sumRange", "sumRange"]
   [[[-2, 0, 3, -5, 2, -1]], [0, 2], [2, 5], [0, 5]]
   Output
   [null, 1, -1, -3]
   
   Explanation
   NumArray numArray = new NumArray([-2, 0, 3, -5, 2, -1]);
   numArray.sumRange(0, 2); // return (-2) + 0 + 3 = 1
   numArray.sumRange(2, 5); // return 3 + (-5) + 2 + (-1) = -1
   numArray.sumRange(0, 5); // return (-2) + 0 + 3 + (-5) + 2 + (-1) = -3
 */

public class RangeSumQueryImmutable_303
{
    private int[] _prefixSums;
    public RangeSumQueryImmutable_303(int[] nums) {
        _prefixSums = new int[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            _prefixSums[i + 1] = _prefixSums[i] + nums[i];
        }
    }
    
    public  int SumRange(int left, int right) // use prefix sum to calculate the sum in O(1) time
    {
        return _prefixSums[right + 1] - _prefixSums[left];
    }
}