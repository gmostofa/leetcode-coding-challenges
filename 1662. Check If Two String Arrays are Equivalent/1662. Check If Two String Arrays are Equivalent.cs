namespace DefaultNamespace;

public class Solution 
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) 
    {
        string s1 = string.Join("", word1);
        string s2 = string.Join("", word2);
        return s1 == s2;
    }
}
