public class Solution {
    public int MinOperations(int[] nums, int k) {
        long sum = 0;
        foreach (int x in nums) sum += x;
        return (int)(sum % k); // remainder is how many single-unit decrements needed
    }
}