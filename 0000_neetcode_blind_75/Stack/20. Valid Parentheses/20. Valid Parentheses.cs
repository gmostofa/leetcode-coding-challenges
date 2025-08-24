public class Solution 
{
    public bool IsValid(string s) 
    {
        
        Stack<char> leftSymbols = new Stack<char>();
       
        foreach (char c in s) 
        {
          
            if (c == '(' || c == '{' || c == '[') 
            {
                leftSymbols.Push(c);
            }
            else if (c == ')' && leftSymbols.Count>0 && leftSymbols.Peek() == '(') 
            {
                leftSymbols.Pop();
            }
            else if (c == '}' && leftSymbols.Count>0 && leftSymbols.Peek() == '{') 
            {
                leftSymbols.Pop();
            } 
            else if (c == ']' && leftSymbols.Count>0 && leftSymbols.Peek() == '[') 
            {
                leftSymbols.Pop();
            }
            else 
            {
                return false;
            }
        }
        if (leftSymbols.Count>0) return false;
        else return true;
    }
}