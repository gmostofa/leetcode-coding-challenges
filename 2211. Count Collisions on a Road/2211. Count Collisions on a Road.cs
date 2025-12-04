public class Solution {
    public int CountCollisions(string directions) {
        char[] s = directions.ToCharArray();
        int n = s.Length;

        int left = 0, right = n - 1;

        // Skip cars going left from the beginning (they leave the road)
        while (left < n && s[left] == 'L')
            left++;

        // Skip cars going right from the end (they leave the road)
        while (right >= 0 && s[right] == 'R')
            right--;

        int collisions = 0;

        for (int i = left; i <= right; i++)
            if (s[i] != 'S')
                collisions++;

        return collisions;
    }
}