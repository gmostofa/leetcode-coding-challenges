public class Solution {
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        string s = x.ToString();
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return s == new string(arr);
    }

}