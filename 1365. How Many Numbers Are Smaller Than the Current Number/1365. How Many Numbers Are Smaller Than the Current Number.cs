namespace DefaultNamespace;

public class Solution 
{
    public int[] SmallerNumbersThanCurrent(int[] nums) 
    {
        int[] freq = new int[101]; 
        
        foreach (int num in nums) 
        {
            freq[num]++;
        }
        
        for (int i = 1; i < 101; i++) 
        {
            freq[i] += freq[i - 1];
        }
        
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) 
        {
            result[i] = nums[i] == 0 ? 0 : freq[nums[i] - 1];
        }
        return result;
    }
}
