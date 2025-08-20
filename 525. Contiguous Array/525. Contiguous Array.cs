namespace DefaultNamespace;

public class Solution 
{
    public int FindMaxLength(int[] nums) 
    {
        Dictionary<int, int> prefixSums = new Dictionary<int, int>();
        prefixSums[0] = -1; 
        int prefixSum = 0;
        int maxLength = 0;
        
        for (int i = 0; i < nums.Length; i++) 
        {
            prefixSum += (nums[i] == 0) ? -1 : 1;
            
            
            if (prefixSums.ContainsKey(prefixSum)) 
            {
                maxLength = Math.Max(maxLength, i - prefixSums[prefixSum]);
            } 
            else
            {
                prefixSums[prefixSum] = i; // Store first occurrence
            }
        }
        
        return maxLength;
    }
}