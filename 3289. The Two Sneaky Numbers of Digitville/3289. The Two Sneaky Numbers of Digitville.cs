public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        int n = nums.Length;
        int maxVal = nums.Length;
        int[] count = new int[maxVal + 1];
        List<int> result = new List<int>(2);

        foreach (int x in nums) {
            count[x]++;
            if (count[x] == 2) {
                result.Add(x);
                if (result.Count == 2)
                    break;
            }
        }
        return result.ToArray();
    }
}