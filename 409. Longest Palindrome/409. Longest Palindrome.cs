public class Solution {
    public int LongestPalindrome(string s)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (freq.ContainsKey(c))
                freq[c]++;
            else
                freq[c] = 1;
        }
        int length = 0;
        bool hasOdd = false;
        foreach (var kvp in freq)
        {
            length += kvp.Value / 2 * 2; 
            if (kvp.Value % 2 == 1)
                hasOdd = true;
        }
        if (hasOdd)
            length += 1; 
        return length;
    }
}