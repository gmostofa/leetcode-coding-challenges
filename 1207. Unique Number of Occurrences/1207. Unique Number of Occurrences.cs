namespace DefaultNamespace;

public class Solution 
{
    public bool UniqueOccurrences(int[] arr) 
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int num in arr) 
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }
        HashSet<int> uniqueFreq = new HashSet<int>();
        foreach (int count in freq.Values) 
        {
            if (!uniqueFreq.Add(count))
                return false;
        }
        return true;
    }
}
