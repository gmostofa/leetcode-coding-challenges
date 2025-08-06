namespace DefaultNamespace;

public class Solution 
{
    public bool BackspaceCompare(string s, string t)
    {
        return Build(s) == Build(t);
    }

    private string Build(string str) 
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in str) 
        {
            if (c != '#') 
            {
                stack.Push(c);
            } 
            else if (stack.Count > 0) 
            {
                stack.Pop();
            }
        }

        return new string(stack.Reverse().ToArray());
    }
}