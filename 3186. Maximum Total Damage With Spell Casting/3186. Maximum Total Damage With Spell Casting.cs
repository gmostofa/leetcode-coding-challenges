public class Solution {
    public long MaximumTotalDamage(int[] power) {
        int n = power.Length;
        if (n == 0) return 0;

        // 1. Count frequencies
        var freq = new Dictionary<long, long>();
        foreach (var x in power) {
            if (!freq.ContainsKey(x)) freq[x] = 0;
            freq[x]++;
        }

        // 2. Get unique sorted damage values
        var unique = freq.Keys.ToList();
        unique.Sort();

        // 3. Precompute next index for each i
        int m = unique.Count;
        int[] nxt = new int[m];
        for (int i = 0; i < m; i++) {
            long curVal = unique[i];
            // find smallest index j > i such that unique[j] > curVal + 2
            int lo = i + 1, hi = m;
            while (lo < hi) {
                int mid = lo + (hi - lo) / 2;
                if (unique[mid] > curVal + 2) hi = mid;
                else lo = mid + 1;
            }
            nxt[i] = lo;  // could be m (out of bounds)
        }

        // 4. DP array: dp[i] = max damage from i to end
        long[] dp = new long[m + 1];
        // dp[m] = 0 by default

        for (int i = m - 1; i >= 0; i--) {
            long skip = dp[i + 1];
            long take = unique[i] * freq[unique[i]];
            if (nxt[i] < m) {
                take += dp[nxt[i]];
            }
            dp[i] = Math.Max(skip, take);
        }

        return dp[0];
    }
}