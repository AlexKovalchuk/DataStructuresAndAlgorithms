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

    public static void RunTests()
    {
        Console.WriteLine("Binary search:");
        int[] nums = [1, 3, 5, 7];
        
        int targetBinary = 5;
        int expectedResultBinary = 2;
        int actualResultBinary = Search(nums, targetBinary);
        Console.WriteLine($"Expected binary: {expectedResultBinary}, actual binary result: {actualResultBinary}");
        
        int[] numsBound = [1, 3, 4, 4, 4, 4, 5, 7];
        int targetBound = 4;
        int expectedResultLowerBound = 2;
        int expectedResultUpperBound = 6;
        int actualResultLowerBound = LowerBound(numsBound, targetBound);
        int actualResultUpperBound = UpperBound(numsBound, targetBound);
        Console.WriteLine($"Expected lower bound: {expectedResultLowerBound}, actual lower bound: {actualResultLowerBound}");
        Console.WriteLine($"Expected upper bound: {expectedResultUpperBound}, actual upper bound: {actualResultUpperBound}");
        
    }
}