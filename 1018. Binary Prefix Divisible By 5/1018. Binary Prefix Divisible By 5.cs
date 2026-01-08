public class Solution {
    public IList<bool> PrefixesDivBy5(int[] nums) {
        List<bool> result = new List<bool>(nums.Length);
        int value = 0;  

        foreach (int bit in nums) {
            value = (value * 2 + bit) % 5;
            result.Add(value == 0);
        }

        
        return result;
    }
}