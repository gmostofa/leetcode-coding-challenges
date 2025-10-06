public class Solution {
    public int TrapRainWater(int[][] heightMap) {
        int m = heightMap.Length, n = heightMap[0].Length;
        if (m < 3 || n < 3) return 0;

        var visited = new bool[m, n];
        var pq = new PriorityQueue<(int height, int r, int c), int>();

        // Add boundary cells to PQ
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (i == 0 || j == 0 || i == m - 1 || j == n - 1) {
                    pq.Enqueue((heightMap[i][j], i, j), heightMap[i][j]);
                    visited[i, j] = true;
                }
            }
        }

        int res = 0;
        int[][] dirs = { new int[]{1,0}, new int[]{-1,0}, new int[]{0,1}, new int[]{0,-1} };

        while (pq.Count > 0) {
            var (height, r, c) = pq.Dequeue();

            foreach (var d in dirs) {
                int nr = r + d[0], nc = c + d[1];
                if (nr < 0 || nc < 0 || nr >= m || nc >= n || visited[nr, nc]) continue;

                visited[nr, nc] = true;

                // If neighbor lower than current boundary, water trapped
                res += Math.Max(0, height - heightMap[nr][nc]);

                // Update boundary height
                pq.Enqueue((Math.Max(heightMap[nr][nc], height), nr, nc),
                    Math.Max(heightMap[nr][nc], height));
            }
        }

        return res;
    }
}