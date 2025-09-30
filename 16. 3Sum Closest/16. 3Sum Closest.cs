namespace DefaultNamespace;

public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int n = nums.Length;
        int closest = nums[0] + nums[1] + nums[2]; // start with first 3

        for (int i = 0; i < n - 2; i++) {
            int left = i + 1, right = n - 1;

            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];

                // Update closest if needed
                if (Math.Abs(sum - target) < Math.Abs(closest - target)) {
                    closest = sum;
                }

                if (sum < target) {
                    left++;
                } else if (sum > target) {
                    right--;
                } else {
                    return sum; // exact match
                }
            }
        }
        return closest;
    }
}
