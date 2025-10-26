public class Solution {
    public int[] ShortestToChar(string s, char c) {
        int n = s.Length;
        int[] result = new int[n];
        int prev = int.MinValue / 2;

        for (int i = 0; i < n; i++) {
            if (s[i] == c) prev = i;
            result[i] = i - prev;
        }

        prev = int.MaxValue / 2;

        for (int i = n - 1; i >= 0; i--) {
            if (s[i] == c) prev = i;
            result[i] = Math.Min(result[i], prev - i);
        }
        return result;
    }
}