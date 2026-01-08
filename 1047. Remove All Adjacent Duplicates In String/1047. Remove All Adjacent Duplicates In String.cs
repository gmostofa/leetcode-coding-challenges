namespace DefaultNamespace;


public class Solution 
{
    public string RemoveDuplicates(string s) 
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in s) {
            if (stack.Count > 0 && stack.Peek() == ch) {
                stack.Pop(); 
            } else {
                stack.Push(ch);
            }
        }

        
        char[] result = stack.ToArray();
        Array.Reverse(result);
        return new string(result);
    }
}