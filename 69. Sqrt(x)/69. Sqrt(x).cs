public class Solution 
{
    public int MySqrt(int x)
    {
        if (x == 0) return 0;

        double r = x;
        while (true)
        {
            double next = (r + x / r) / 2;
            if (Math.Abs(r - next) < 1e-7) // convergence check
                break;
            r = next;
        }
        return (int)r;
    }
}