namespace DefaultNamespace;

public class Solution 
{
    public int SumOfUnique(int[] nums)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        int sum = 0;
        foreach (var kvp in freq)
        {
            if (kvp.Value == 1)
                sum += kvp.Key;
        }
        return sum;
    }

}