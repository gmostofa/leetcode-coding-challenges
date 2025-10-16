public class Solution {
    public int MaximumGap(int[] nums) {
        if (nums.Length < 2) return 0;

        int minVal = nums.Min();
        int maxVal = nums.Max();
        int n = nums.Length;

        // If all numbers are same
        if (minVal == maxVal) return 0;

        // Bucket size
        int bucketSize = Math.Max(1, (maxVal - minVal) / (n - 1));
        int bucketCount = (maxVal - minVal) / bucketSize + 1;

        int[] bucketMin = new int[bucketCount];
        int[] bucketMax = new int[bucketCount];
        bool[] hasNum = new bool[bucketCount];

        for (int i = 0; i < bucketCount; i++) {
            bucketMin[i] = int.MaxValue;
            bucketMax[i] = int.MinValue;
        }

        // Fill buckets
        foreach (int num in nums) {
            int idx = (num - minVal) / bucketSize;
            hasNum[idx] = true;
            bucketMin[idx] = Math.Min(bucketMin[idx], num);
            bucketMax[idx] = Math.Max(bucketMax[idx], num);
        }

        // Find max gap
        int maxGap = 0;
        int prevMax = minVal;

        for (int i = 0; i < bucketCount; i++) {
            if (!hasNum[i]) continue;
            maxGap = Math.Max(maxGap, bucketMin[i] - prevMax);
            prevMax = bucketMax[i];
        }

        return maxGap;
    }
}