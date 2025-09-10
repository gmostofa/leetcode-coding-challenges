public class Solution {
    public void NextPermutation(int[] nums) {
        int n = nums.Length;
        int i = n - 2;

        // 1. Find first decreasing element from right
        while (i >= 0 && nums[i] >= nums[i + 1]) {
            i--;
        }

        if (i >= 0) {
            // 2. Find element just larger than nums[i]
            int j = n - 1;
            while (nums[j] <= nums[i]) {
                j--;
            }

            // 3. Swap nums[i] and nums[j]
            Swap(nums, i, j);
        }

        // 4. Reverse suffix
        Reverse(nums, i + 1, n - 1);
    }

    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    private void Reverse(int[] nums, int left, int right) {
        while (left < right) {
            Swap(nums, left++, right--);
        }
    }
}