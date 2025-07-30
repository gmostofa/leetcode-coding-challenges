namespace DefaultNamespace;

public class Solution 
{
    public string SortSentence(string s) 
    {
        string[] words = s.Split(' ');
        string[] result = new string[words.Length];

        foreach (var word in words) 
        {
            int pos = word[word.Length-1] - '1'; 
            result[pos] = word.Substring(0, word.Length - 1); 
        }

        return string.Join(" ", result);
    }
}