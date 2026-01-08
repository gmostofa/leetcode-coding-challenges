public class Solution
{
    public int MaxDotProduct(int[] nums1, int[] nums2)
    {
        int n = nums1.Length;
        int m = nums2.Length;

        int[,] dp = new int[n + 1, m + 1];

        // Initialize with very small value
        for (int i = 0; i <= n; i++)
        for (int j = 0; j <= m; j++)
            dp[i, j] = int.MinValue;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                int product = nums1[i - 1] * nums2[j - 1];

                dp[i, j] = Math.Max(
                    product,
                    Math.Max(
                        dp[i - 1, j - 1] == int.MinValue
                            ? product
                            : dp[i - 1, j - 1] + product,
                        Math.Max(dp[i - 1, j], dp[i, j - 1])
                    )
                );
            }
        }

        return dp[n, m];
    }
}