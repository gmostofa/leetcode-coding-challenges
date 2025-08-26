public class Solution
{
    public bool CheckPerfectNumber(int num)
    {
        if (num <= 1) return false;

        int sum = 1; 
        int limit = (int)Math.Sqrt(num);

        for (int d = 2; d <= limit; d++)
        {
            if (num % d == 0)
            {
                int q = num / d;
                sum += d;
                if (q != d) sum += q;
            }
        }

        return sum == num;
    }
}