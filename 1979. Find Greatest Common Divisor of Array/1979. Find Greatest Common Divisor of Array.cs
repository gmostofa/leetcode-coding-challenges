namespace DefaultNamespace;

public class Solution 
{
    public int FindGCD(int[] nums) 
    {
        int minVal = nums.Min();
        int maxVal = nums.Max();
        return GCD(minVal, maxVal);
    }

    private int GCD(int a, int b) 
    {
        while (b != 0) 
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}