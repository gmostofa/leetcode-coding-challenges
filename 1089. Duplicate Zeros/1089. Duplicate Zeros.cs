namespace DefaultNamespace;


public class Solution 
{
    public void DuplicateZeros(int[] arr) 
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++) 
        {
            if (arr[i] == 0) 
            {
                for (int j = n - 1; j > i; j--) 
                {
                    arr[j] = arr[j - 1];
                }
                if (i + 1 < n) 
                {
                    arr[i + 1] = 0;
                }
                i++; 
            }
        }
    }
}