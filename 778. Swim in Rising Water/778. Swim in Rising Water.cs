using System.Collections.Generic;

public class Solution {
    public int SwimInWater(int[][] grid) {
        int n = grid.Length;
        int[,] dirs = new int[,] { {1,0}, {-1,0}, {0,1}, {0,-1} };
        
        var pq = new PriorityQueue<(int row, int col, int time), int>();
        pq.Enqueue((0, 0, grid[0][0]), grid[0][0]);
        
        bool[,] visited = new bool[n,n];
        
        while (pq.Count > 0) {
            var (r, c, time) = pq.Dequeue();
            
            if (visited[r, c]) continue;
            visited[r, c] = true;
            
            if (r == n-1 && c == n-1) return time;
            
            for (int i = 0; i < 4; i++) {
                int nr = r + dirs[i,0];
                int nc = c + dirs[i,1];
                
                if (nr >= 0 && nr < n && nc >= 0 && nc < n && !visited[nr,nc]) {
                    int newTime = Math.Max(time, grid[nr][nc]);
                    pq.Enqueue((nr, nc, newTime), newTime);
                }
            }
        }
        return -1; // should never happen
    }
}