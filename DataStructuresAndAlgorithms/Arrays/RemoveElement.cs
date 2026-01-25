namespace DataStructuresAndAlgorithms.arrays;

/*
   Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. 
   The order of the elements may be changed. 
   Then return the number of elements in nums which are not equal to val.
   
   Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:
   
   Change the array nums such that the first k elements of nums contain the elements which are not equal to val. 
   The remaining elements of nums are not important as well as the size of nums.
   Return k.
   Custom Judge:
   The judge will test your solution with the following code:
   
   int[] nums = [...]; // Input array
   int val = ...; // Value to remove
   int[] expectedNums = [...]; // The expected answer with correct length.
                               // It is sorted with no values equaling val.
   
   int k = removeElement(nums, val); // Calls your implementation
   
   assert k == expectedNums.length;
   sort(nums, 0, k); // Sort the first k elements of nums
   for (int i = 0; i < actualLength; i++) {
       assert nums[i] == expectedNums[i];
   }
   If all assertions pass, then your solution will be accepted.
   
   Example 1:
   
   Input: nums = [3,2,2,3], val = 3
   Output: 2, nums = [2,2,_,_]
   Explanation: Your function should return k = 2, with the first two elements of nums being 2.
   It does not matter what you leave beyond the returned k (hence they are underscores).
 */

public class RemoveElement
{
    public static int RemoveElementBruteForce(int[] nums, int val)
    {
        var k = nums.Length;
        for (int i = 0; i < k; )
        {
            if (nums[i] != val)
            {
                // just continue;
                i++;
            }
            else if (nums[i] == val && nums[k-1] != val)
            {
                // move this value to the end.
                nums[i] = nums[k - 1];
                i++;
            }
            
            k--;
        }
        return k;
    }

    public static void RunTests()
    {
        int[] test1 = [3, 2, 2, 3];
        int result1 = RemoveElementBruteForce(test1, 3);
        Console.WriteLine("result1 = " + result1);
        for (int i = 0; i < result1; i++)
        {
            Console.Write(test1[i] + " ");
        }
    }

    public static void BubbleSort(int[] nums, bool ascending = true)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (ascending ? nums[i] > nums[j] : nums[j] > nums[i])
                {
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                }
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            // Console.WriteLine(nums[i]);
        }
    }
}