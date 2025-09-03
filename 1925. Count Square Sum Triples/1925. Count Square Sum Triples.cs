using System.Collections.Generic;

public class Solution {
    public int CountTriples(int n) {
        HashSet<long> squares = new HashSet<long>();
        for (int i = 1; i <= n; i++) {
            squares.Add((long)i * i);
        }
        
        int count = 0;
        for (int a = 1; a <= n; a++) {
            for (int b = 1; b <= n; b++) {
                long sumSquares = (long)a * a + (long)b * b;
                if (squares.Contains(sumSquares)) {
                    count++;
                }
            }
        }
        return count;
    }
}