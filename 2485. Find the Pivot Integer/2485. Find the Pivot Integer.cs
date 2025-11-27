namespace DefaultNamespace;

public class Solution 
{
    public int PivotInteger(int n)
    {
        int totalSum = (n * (n + 1)) / 2;
        int x = (int)Math.Sqrt(totalSum);

        if (x * x == totalSum)
            return x;
        return -1;
        
    }
}