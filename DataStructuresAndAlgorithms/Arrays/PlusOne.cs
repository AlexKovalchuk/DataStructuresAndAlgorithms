using System.Text;
using DataStructuresAndAlgorithms.Helpers;

namespace DataStructuresAndAlgorithms.Arrays;

/*
 * 66. Plus One
    You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. 
    The digits are ordered from most significant to least significant in left-to-right order. 
    The large integer does not contain any leading 0's.
   
   Increment the large integer by one and return the resulting array of digits.
   
   Example 1:
   
   Input: digits = [1,2,3]
   Output: [1,2,4]
   Explanation: The array represents the integer 123.
   Incrementing by one gives 123 + 1 = 124.
   Thus, the result should be [1,2,4].
   Example 2:
   
   Input: digits = [4,3,2,1]
   Output: [4,3,2,2]
   Explanation: The array represents the integer 4321.
   Incrementing by one gives 4321 + 1 = 4322.
   Thus, the result should be [4,3,2,2].
   Example 3:
   
   Input: digits = [9]
   Output: [1,0]
   Explanation: The array represents the integer 9.
   Incrementing by one gives 9 + 1 = 10.
   Thus, the result should be [1,0].
    
   
   Constraints:
   
   1 <= digits.length <= 100
   0 <= digits[i] <= 9
   digits does not contain any leading 0's.
 */

public class PlusOne
{
    public static int[] IncrementTheLargestIntegerByOneBruteForce(int[] nums)
    {
        StringBuilder number = new StringBuilder();
        for (int i = 0; i < nums.Length; i++)
        {
            number.Append(nums[i]);
        }
        Console.WriteLine($"number is: {number}");
        int increasedNumber = Int32.Parse(number.ToString()) + 1;
        Console.WriteLine($"increased number is: {increasedNumber}");

        int[] digits = increasedNumber
            .ToString()
            .Select(c => c - '0')
            .ToArray();
        return digits;
    }

    public static int[] IncrementTheLargestIntegerByOne(int[] digits)
    {
        int numberForCarrying = 0;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            int tmp = i == digits.Length-1 ? digits[i] + 1 : digits[i];
            if (tmp + numberForCarrying > 9)
            {
                digits[i] = 0;
                numberForCarrying = 1;
            }
            else
            {
                digits[i] = tmp + numberForCarrying;
                numberForCarrying = 0;
            }
        }

        if (numberForCarrying != 0)
        {
            int [] biggerNums =  new int[digits.Length+1];
            for (int i = 0; i < biggerNums.Length; i++)
            {
                if (i == 0)
                {
                    biggerNums[i] = numberForCarrying;
                    numberForCarrying = 0;
                }
                else
                {
                    biggerNums[i] = 0;
                }
            }

            return biggerNums;
        }
        
        return digits;
    }

    public static void RunTests()
    {
        int[] digits = [1, 2, 3];
        var result = IncrementTheLargestIntegerByOne(digits);
        ArrayHelper.PrintArray(result, "nums: ");
        int[] digits2 = [4,3,2,1];
        var result2 = IncrementTheLargestIntegerByOne(digits2);
        ArrayHelper.PrintArray(result2, "nums 2: ");
        int[] digits3 = [9,9,9,9];
        var result3 = IncrementTheLargestIntegerByOne(digits3);
        ArrayHelper.PrintArray(result3, "nums 3: ");
        int[] digits4 = [8,9,9,9];
        var result4 = IncrementTheLargestIntegerByOne(digits4);
        ArrayHelper.PrintArray(result4, "nums 4: ");
    } 
}