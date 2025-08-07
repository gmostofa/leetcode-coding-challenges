namespace DefaultNamespace;

public class Solution 
{
    public bool IsBalanced(string num) 
    {
        int evenSum = 0;
        int oddSum = 0;
        for (int i = 0; i < num.Length; i++) 
        {
            int digit = num[i] - '0';

            if (i % 2 == 0)
            {
                evenSum += digit;
            }
            else
            {
                oddSum += digit;
            }
        }
        return evenSum == oddSum;
    }
}