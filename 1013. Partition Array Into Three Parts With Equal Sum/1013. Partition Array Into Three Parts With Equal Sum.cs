namespace DefaultNamespace;

public class Solution {
    public bool CanThreePartsEqualSum(int[] arr) 
    {
        if (arr == null || arr.Length < 3) return false;
        long totalSum = 0;
        foreach (int num in arr) 
        {
            totalSum += num;
        }
        
      
        if (totalSum % 3 != 0) return false;
        long target = totalSum / 3;
        
        long currentSum = 0;
        int partsFound = 0;
        
        for (int i = 0; i < arr.Length; i++) 
        {
            currentSum += arr[i];
            if (currentSum == target) 
            {
                partsFound++;
                currentSum = 0;
                if (partsFound == 2 && i < arr.Length - 1) 
                {
                    return true;
                }
            }
        }
        
        return partsFound >= 3 && currentSum == 0;
    }
}