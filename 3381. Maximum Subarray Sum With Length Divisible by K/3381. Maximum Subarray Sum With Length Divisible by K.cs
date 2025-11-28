public class Solution {
    public long MaxSubarraySum(int[] nums, int k) {
        int n = nums.Length;

        long[] minPrefix = new long[k];
        for (int i = 0; i < k; i++)
            minPrefix[i] = long.MaxValue;

        long prefix = 0;
        minPrefix[0] = 0;   // prefix[0] = 0 at index 0

        long ans = long.MinValue;

        for (int i = 0; i < n; i++) {
            prefix += nums[i];
            int mod = (i + 1) % k; // prefix index is i+1

            if (minPrefix[mod] != long.MaxValue) {
                ans = Math.Max(ans, prefix - minPrefix[mod]);
            }

            // update minimum prefix for this modulo group
            minPrefix[mod] = Math.Min(minPrefix[mod], prefix);
        }
        return ans;
    }
}