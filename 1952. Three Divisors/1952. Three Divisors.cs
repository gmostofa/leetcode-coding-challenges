namespace DefaultNamespace;

public class Solution 
{
    public bool IsThree(int n) 
    {
        int root = (int)Math.Sqrt(n);

        if (root * root != n) return false;

        return IsPrime(root);
    }

    private bool IsPrime(int num) 
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++) 
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}