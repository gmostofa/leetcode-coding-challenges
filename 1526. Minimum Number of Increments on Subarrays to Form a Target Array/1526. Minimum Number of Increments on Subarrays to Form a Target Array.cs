namespace DefaultNamespace;


public class Solution 
{
    public int MinNumberOperations(int[] target) 
    {
        if (target == null || target.Length == 0) return 0;

        int n = target.Length;
        int operations = target[0];

        for (int i = 1; i < n; i++) {
            if (target[i] > target[i - 1]) {
                operations += target[i] - target[i - 1];
            }
        }

        return operations;
    }
    
}