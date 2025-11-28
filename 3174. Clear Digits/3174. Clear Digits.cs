namespace DefaultNamespace;

public class Solution 
{
    public string ClearDigits(string s) 
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s) 
        {
            if (char.IsLetter(c)) 
            {
                stack.Push(c);
            } 
            else if (char.IsDigit(c) && stack.Count > 0) 
            {
                stack.Pop(); 
            }
        }
        
        return new string(stack.Reverse().ToArray());
    }
}