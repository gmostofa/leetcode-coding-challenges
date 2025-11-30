public class Solution {
    public int MinSubarray(int[] nums, int p) {
        long total = 0;
        foreach (int x in nums) total += x;

        int rem = (int)(total % p);
        if (rem == 0) return 0;

        Dictionary<int, int> map = new Dictionary<int, int>();
        map[0] = -1;  // prefix before array

        long prefix = 0;
        int res = nums.Length;

        for (int i = 0; i < nums.Length; i++) {
            prefix = (prefix + nums[i]) % p;

            int need = (int)((prefix - rem + p) % p);

            if (map.ContainsKey(need)) {
                res = Math.Min(res, i - map[need]);
            }

            // store current prefix mod
            map[(int)prefix] = i;
        }

        return res == nums.Length ? -1 : res;
    }
}