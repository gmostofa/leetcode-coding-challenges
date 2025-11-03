namespace DefaultNamespace;


public class Solution 
{
    public int FindMiddleIndex(int[] nums) 
    {
        if (nums == null || nums.Length == 0) return -1;
    
        int totalSum = 0;
        foreach (int num in nums) 
        {
            totalSum += num;
        }
   
        int leftSum = 0;
        for (int i = 0; i < nums.Length; i++) 
        {
            int rightSum = totalSum - nums[i] - leftSum;
            if (leftSum == rightSum) 
            {
                return i;
            }
            leftSum += nums[i];
        }
        
        return -1;
    }
}