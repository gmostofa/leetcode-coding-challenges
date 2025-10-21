public class Solution 
{
    public int SumOddLengthSubarrays(int[] arr) 
    {
        int sum = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = i; j < arr.Length; j+=2)
            {
                for(int k = i; k <= j; k++)
                {
                    sum += arr[k];
                } 
            }
        }
        
        return sum;
    }
}