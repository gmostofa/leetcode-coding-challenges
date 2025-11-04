namespace DefaultNamespace;


public class Solution 
{
    public string ReversePrefix(string word, char ch) 
    {
        Stack<char> stack = new Stack<char>();
        int index = -1;
        for (int i = 0; i < word.Length; i++) 
        {
            stack.Push(word[i]);
            if (word[i] == ch) 
            {
                index = i;
                break;
            }
        }
        if (index == -1) 
        {
            return word;
        }
        StringBuilder result = new StringBuilder();
        while (stack.Count > 0) 
        {
            result.Append(stack.Pop());
        }
        for (int i = index+1; i < word.Length; i++) 
        {
            result.Append(word[i]);
        }
        return result.ToString();
    }
}
