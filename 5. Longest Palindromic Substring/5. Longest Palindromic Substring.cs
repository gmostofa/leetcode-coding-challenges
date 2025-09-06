public class Solution {
    public string LongestPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) {
            return "";
        }
        
        int start = 0;
        int maxLength = 1;
        
        for (int i = 0; i < s.Length; i++) {
            // Odd-length palindrome centered at i
            ExpandAroundCenter(s, i, i, ref start, ref maxLength);
            
            // Even-length palindrome centered between i and i+1
            ExpandAroundCenter(s, i, i + 1, ref start, ref maxLength);
        }
        
        return s.Substring(start, maxLength);
    }
    
    private void ExpandAroundCenter(string s, int left, int right, ref int start, ref int maxLength) {
        while (left >= 0 && right < s.Length && s[left] == s[right]) {
            int currentLength = right - left + 1;
            if (currentLength > maxLength) {
                start = left;
                maxLength = currentLength;
            }
            left--;
            right++;
        }
    }
}