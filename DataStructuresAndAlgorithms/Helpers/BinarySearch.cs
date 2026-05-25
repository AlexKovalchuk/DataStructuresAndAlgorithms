namespace DataStructuresAndAlgorithms.Helpers;

public class BinarySearch
{
    public static int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target) {
                return mid;
            }
            if (nums[mid] > target)
                right = mid - 1;
            else
                left = mid + 1;
        }

        return -1;
    }
    
    public static int LowerBound(int[] nums, int target)
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
}