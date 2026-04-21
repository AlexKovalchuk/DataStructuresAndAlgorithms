namespace DataStructuresAndAlgorithms.Strings;

/* 20. Valid Parentheses
   Given a string s containing just the characters '(', ')', '{', '}', '[' and ']',
   determine if the input string is valid.
   An input string is valid if:
   Open brackets must be closed by the same type of brackets.
   Open brackets must be closed in the correct order.
   Every close bracket has a corresponding open bracket of the same type. 
 */

public static class ValidParentheses20
{
    public static bool IsValid(string s) {
        if(s.Length == 1 || s.Length % 2 != 0) return false;
        var brackets = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };
        Stack<char> signs = new Stack<char>();
        foreach (var sign in s)
        {
            if (sign is '(' or '{' or '[')
            {
                signs.Push(sign);
            } else if (signs.Count > 0 && signs.Peek() == brackets[sign])
            {
                signs.Pop();
            }
            else
            {
                return false;
            }
        }
        
        return signs.Count == 0;
    }
}