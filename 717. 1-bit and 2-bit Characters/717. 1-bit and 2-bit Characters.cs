public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        int i = 0;
        int n = bits.Length;

        while (i < n - 1) {  // stop before last element
            if (bits[i] == 1)
                i += 2;     // 2-bit character
            else
                i += 1;     // 1-bit character
        }

        return i == n - 1;  // landed on last index?
    }
}