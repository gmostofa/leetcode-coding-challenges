public class Solution {
    private int result;
    private int K;
    private int[] values;
    private List<int>[] graph;

    public int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k) {
        this.values = values;
        this.K = k;
        result = 0;

        // build adjacency list
        graph = new List<int>[n];
        for (int i = 0; i < n; i++)
            graph[i] = new List<int>();

        foreach (var e in edges) {
            graph[e[0]].Add(e[1]);
            graph[e[1]].Add(e[0]);
        }

        DFS(0, -1);

        return result;
    }

    private int DFS(int node, int parent) {
        long sum = values[node];

        foreach (int nei in graph[node]) {
            if (nei == parent) continue;

            int childSum = DFS(nei, node);
            sum += childSum;
        }

        if (sum % K == 0) {
            result++;
            return 0;
        }

        return (int)(sum % K);
    }
}