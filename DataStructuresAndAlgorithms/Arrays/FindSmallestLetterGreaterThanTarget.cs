namespace DataStructuresAndAlgorithms.Arrays;

/* 744. Search Insert Position
 * You are given an array of characters letters that is sorted in non-decreasing order, and a character target.
   There are at least two different characters in letters.
   Return the smallest character in letters that is lexicographically greater than target.
   If such a character does not exist, return the first character in letters.
   
   Example 1:
   Input: letters = ["c","f","j"], target = "a"
   Output: "c"
   Explanation: The smallest character that is lexicographically greater than 'a' in letters is 'c'.\
   
   Example 2:
   Input: letters = ["c","f","j"], target = "c"
   Output: "f"
   Explanation: The smallest character that is lexicographically greater than 'c' in letters is 'f'.
   
   Example 3:
   Input: letters = ["x","x","y","y"], target = "z"
   Output: "x"
   Explanation: There are no characters in letters that is lexicographically greater than 'z' so we return letters[0].
 */

public static class FindSmallestLetterGreaterThanTarget
{
    public static char NextGreatestLetter(char[] letters, char target) {
        
        int left = 0;
        int right = letters.Length - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (letters[mid] > target)
                right = mid - 1;
            else
                left = mid + 1;
        }
        
        return letters[left % letters.Length];
    }

    public static void RunTests()
    {
        // Example 1:
        char[] letters = ['c', 'f', 'j'];
        char target = 'a';
        char expected = 'c';
        var result =  NextGreatestLetter(letters, target);
        Console.WriteLine($"Example 1: target: {target}. expected: {expected}. result: {result}");
        
        // Example 2:
        char[] letters2 = ['c', 'f', 'j'];
        char target2 = 'c';
        char expected2 = 'f';
        var result2 =  NextGreatestLetter(letters2, target2);
        Console.WriteLine($"Example 2: target: {target2}. expected: {expected2}. result: {result2}");
        
        // Example 3:
        char[] letters3 = ['x', 'x', 'y', 'y'];
        char target3 = 'z';
        char expected3 = 'x';
        var result3 =  NextGreatestLetter(letters3, target3);
        Console.WriteLine($"Example 3: target: {target3}. expected: {expected3}. result: {result3}");
    }
}