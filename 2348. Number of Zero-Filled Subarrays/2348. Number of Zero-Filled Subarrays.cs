namespace DefaultNamespace;

public class Solution 
{
    public long ZeroFilledSubarray(int[] nums) 
    {
        long result = 0;
        long count = 0; 
        foreach (int num in nums) 
        {
            if (num == 0) 
            {
                count++;
            } 
            else 
            {
                result += count * (count + 1) / 2;
                count = 0; 
            }
        }
        if (count > 0) 
        {
            result += count * (count + 1) / 2;
        }
        return result;
    }
}