using DataStructuresAndAlgorithms.Helpers;

namespace DataStructuresAndAlgorithms.Arrays;

/*
   88. Merge Sorted Array

   You are given two integer arrays nums1 and nums2, sorted in non-decreasing order,
   and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
   
   Merge nums1 and nums2 into a single array sorted in non-decreasing order.
   
   The final sorted array should not be returned by the function, 
   but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, 
   where the first m elements denote the elements that should be merged, and the last n elements are 
   set to 0 and should be ignored. nums2 has a length of n.
   
   Example 1:
   Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
   Output: [1,2,2,3,5,6]
   Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
   The nums1 of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.

   Example 2:   
   Input: nums1 = [1], m = 1, nums2 = [], n = 0
   Output: [1]
   Explanation: The arrays we are merging are [1] and [].
   The nums1 of the merge is [1].
   
   Example 3:

   Input: nums1 = [0], m = 0, nums2 = [1], n = 1
   Output: [1]
   Explanation: The arrays we are merging are [] and [1].
   The nums1 of the merge is [1].
   Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge nums1 can fit in nums1.
 */

public class MergeSortedArray
{
    public static void Merge_1(int[] nums1, int m, int[] nums2, int n) 
    {
        int[] arr1 = new int[m];
        Array.Copy(nums1, arr1, m);
        int i = 0, j = 0;
        int k = 0;

        while (i < m && j < n) {
            if (arr1[i] <= nums2[j]) {
                nums1[k] = arr1[i];
                i++;
                
            }
            else {
                nums1[k] = nums2[j];
                j++;
                
            }
            k++;
        }
        while (i < m)
        {
            nums1[k] = arr1[i];
            i++;
            k++;
        }
        while (j < n)
        {
            nums1[k] =  nums2[j];
            j++;
            k++;
        }
    }

    public static void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        int i = m-1, j = n-1;
        int k = nums1.Length-1;

        while (i >= 0 && j >= 0) {
            if (nums1[i] > nums2[j]) {
                nums1[k] = nums1[i];
                i--;
            }
            else {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }
        while (j >= 0)
        {
            nums1[k] =  nums2[j];
            j--;
            k--;
        }
    }
    public static void RunTests()
    {
        int[] nums1 = [1, 2, 3, 0, 0, 0];
        int m = 3;
        int[] nums2 = [2, 5, 6];
        int n = 3;
        Merge(nums1, m,nums2, n);
        ArrayHelper.PrintArray(nums1, "Merge two sub arrays: [1, 2, 3, 0, 0, 0] && [2, 5, 6], Expected result: [1,2,2,3,5,6]");
        
        // Example 2
        int[] nums1_2 = [1];
        int m2 = 1;
        int[] nums2_2 = [];
        int n2 = 0;
        Merge(nums1_2, m2, nums2_2, n2);
        ArrayHelper.PrintArray(
            nums1_2,
            "Example 2: nums1=[1], m=1; nums2=[], n=0. Expected: [1]"
        );

        // Example 3
        int[] nums1_3 = [0];
        int m3 = 0;
        int[] nums2_3 = [1];
        int n3 = 1;

        Merge(nums1_3, m3, nums2_3, n3);
        ArrayHelper.PrintArray(
            nums1_3,
            "Example 3: nums1=[0], m=0; nums2=[1], n=1. Expected: [1]"
        );
    }
    
}