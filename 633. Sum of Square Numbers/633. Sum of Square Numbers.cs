namespace DefaultNamespace;

public class Solution 
{
    public bool JudgeSquareSum(int c) 
    {
        long left = 0;
        long right = (long)Math.Sqrt(c);

        while (left <= right) 
        {
            long sum = left * left + right * right;

            if (sum == c)
                return true;
            else if (sum < c)
                left++;
            else
                right--;
        }

        return false;
    }
}