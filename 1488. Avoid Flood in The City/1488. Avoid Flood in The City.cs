namespace DefaultNamespace;
using System.Collections.Generic;

public class Solution {
    public int[] AvoidFlood(int[] rains) {
        int n = rains.Length;
        int[] ans = new int[n];
        HashSet<int> fullLakes = new HashSet<int>();
        Dictionary<int, Queue<int>> nextRain = new Dictionary<int, Queue<int>>();
        PriorityQueue<(int lake, int nextDay), int> pq = new PriorityQueue<(int, int), int>();
        
        for (int i = 0; i < n; i++) {
            if (rains[i] > 0) {
                if (!nextRain.ContainsKey(rains[i]))
                    nextRain[rains[i]] = new Queue<int>();
                nextRain[rains[i]].Enqueue(i);
            }
        }
        
        for (int i = 0; i < n; i++) {
            if (rains[i] > 0) {
                ans[i] = -1; 
                int lake = rains[i];
                
                nextRain[lake].Dequeue();
                
                
                if (fullLakes.Contains(lake))
                    return new int[0]; // flooded
                
                fullLakes.Add(lake);
                
                
                if (nextRain[lake].Count > 0)
                    pq.Enqueue((lake, nextRain[lake].Peek()), nextRain[lake].Peek());
            } 
            else {
                
                if (pq.Count > 0) {
                    var (lake, _) = pq.Dequeue();
                    ans[i] = lake;
                    fullLakes.Remove(lake);
                } else {
                    ans[i] = 1;
                }
            }
        }
        
        return ans;
    }
}
