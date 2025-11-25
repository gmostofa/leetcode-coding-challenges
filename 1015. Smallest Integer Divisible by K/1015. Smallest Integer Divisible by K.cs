public class Solution {
    public int SmallestRepunitDivByK(int K) {
        // if K has factor 2 or 5 → impossible
        if (K % 2 == 0 || K % 5 == 0)
            return -1;

        int num = 0;

        for (int length = 1; length <= K; length++) {
            num = (num * 10 + 1) % K;
            if (num == 0)
                return length;
        }

        return -1; // should never reach here for valid K
    }
}