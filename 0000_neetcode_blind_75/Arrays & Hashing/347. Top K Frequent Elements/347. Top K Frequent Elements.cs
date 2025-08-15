namespace DefaultNamespace;

public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        
        Dictionary<int, int> freqMap = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (!freqMap.ContainsKey(num))
                freqMap[num] = 0;
            freqMap[num]++;
        }

        var sorted = freqMap.OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();

        return sorted;
    }

}