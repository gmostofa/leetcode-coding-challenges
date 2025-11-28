public class Solution {
    public int CountValidSelections(int[] nums) {
        int n = nums.Length;
        long total = 0;
        foreach (int x in nums) total += x;

        long leftSum = 0;
        int result = 0;

        for (int i = 0; i < n; i++) {
            if (nums[i] == 0) {
                long rightSum = total - leftSum;
                if (leftSum == rightSum) {
                    result += 2;
                } else if (Math.Abs(leftSum - rightSum) == 1) {
                    result += 1;
                }
            }
            leftSum += nums[i];
        }
        
        return result;
    }
}