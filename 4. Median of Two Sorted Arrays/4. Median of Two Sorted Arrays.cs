﻿public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        // Ensure nums1 is smaller for binary search efficiency
        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1);

        int m = nums1.Length, n = nums2.Length;
        int totalLeft = (m + n + 1) / 2;

        int left = 0, right = m;
        while (left <= right) {
            int i = (left + right) / 2;          // partition in nums1
            int j = totalLeft - i;               // partition in nums2

            int left1 = (i == 0) ? int.MinValue : nums1[i - 1];
            int right1 = (i == m) ? int.MaxValue : nums1[i];
            int left2 = (j == 0) ? int.MinValue : nums2[j - 1];
            int right2 = (j == n) ? int.MaxValue : nums2[j];

            if (left1 <= right2 && left2 <= right1) {
                if ((m + n) % 2 == 0)
                    return (Math.Max(left1, left2) + Math.Min(right1, right2)) / 2.0;
                else
                    return Math.Max(left1, left2);
            } else if (left1 > right2) {
                right = i - 1;
            } else {
                left = i + 1;
            }
        }

        throw new InvalidOperationException("No median found");
    }
}