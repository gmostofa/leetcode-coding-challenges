public class Solution 
{
    public int Reverse(int x) 
    {
        if (x == 0) return 0;
        
        int sign = x < 0 ? -1 : 1;
        long num = Math.Abs((long)x);
        
        long reversed = 0;
        while (num > 0) 
        {
            int digit = (int)(num % 10);
            num /= 10;
            reversed = reversed * 10 + digit;
            
            if (reversed > int.MaxValue || reversed < int.MinValue) 
            {
                return 0;
            }
        }
        return (int)(sign * reversed);
    }
}