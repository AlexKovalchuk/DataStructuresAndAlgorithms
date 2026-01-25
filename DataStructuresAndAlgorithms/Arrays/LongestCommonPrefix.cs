using System.Text;

namespace DataStructuresAndAlgorithms.arrays;

/*
 * Write a function to find the longest common prefix string amongst an array of strings.
   If there is no common prefix, return an empty string "".
   
   Example 1:
   Input: strs = ["flower","flow","flight"]
   Output: "fl"
   Example 2:
   
   Input: strs = ["dog","racecar","car"]
   Output: ""
   Explanation: There is no common prefix among the input strings.
   
   Constraints:
   1 <= strs.length <= 200
   0 <= strs[i].length <= 200
   strs[i] consists of only lowercase English letters if it is non-empty.
 */

public static class LongestCommonPrefix
{
    public static string FindLongestCommonPrefixSimple(string[] strs)
    {
        string longestPrefix = "";
        if (strs.Length == 0) return longestPrefix;
        
        for (int i = 0; i < strs[0].Length; i++)
        {
            string tmpLetter = "";
            foreach (string str in strs)
            {
                if(tmpLetter == "")  tmpLetter = str[i].ToString();
                else if(str[i].ToString() != tmpLetter)
                {
                    return longestPrefix;
                }
            }
            longestPrefix += tmpLetter;
        }
        
        return longestPrefix;
    }
    
    public static string FindLongestCommonPrefixOptimized(string[] strs)
    {
        StringBuilder longestPrefixSb = new StringBuilder();
        if (strs.Length == 0) return "";
        
        for (int i = 0; i < strs[0].Length; i++)
        {
            char? tmpLetter = null;
            foreach (string str in strs)
            {
                if(i >= str.Length) return longestPrefixSb.ToString();
                if (tmpLetter == null)
                {
                    tmpLetter = str[i];
                }
                else if(str[i] != tmpLetter)
                {
                    return longestPrefixSb.ToString();
                }
            }
            longestPrefixSb.Append(tmpLetter);
        }
        
        return longestPrefixSb.ToString();
    }

	public static string FindLongestCommonPrefixSeniorOptimization(string[] strs)
    {
        if (strs.Length == 0) return "";
        
        StringBuilder longestPrefixSb = new StringBuilder();
		Array.Sort(strs);
        
        var firstElement = strs[0];
        var lastElement = strs[strs.Length - 1];
        var length = firstElement.Length <= lastElement.Length ? firstElement.Length : lastElement.Length;
        for (int i = 0; i < length; i++)
        {
            if (firstElement[i] == lastElement[i])
            {
                longestPrefixSb.Append(firstElement[i]);
            }
            else
            {
                return longestPrefixSb.ToString();
            }
        }
		
        return longestPrefixSb.ToString();
	}

    public static void RunTests()
    {
        Console.WriteLine("===========================");
        Console.WriteLine("Find Longest Common Prefix Simple: \"fly\", \"flower\", \"flow\", \"flight\", \"flertoux\", \"flez\", \"flyra\"");
        string[] strs = ["fly", "flower", "flow", "flight", "flertoux", "flez", "flyra"];
        var result = FindLongestCommonPrefixSimple(strs);
        Console.WriteLine(result);
        
        Console.WriteLine("Find Longest Common Prefix Optimized: flower, flow, flight");
        var result2 = FindLongestCommonPrefixOptimized(strs);
        Console.WriteLine(result2);
        
        Console.WriteLine("Find Longest Common Prefix Senior Optimized:");
        var result3 = FindLongestCommonPrefixSeniorOptimization(strs);
        Console.WriteLine(result3);
        
    }
}