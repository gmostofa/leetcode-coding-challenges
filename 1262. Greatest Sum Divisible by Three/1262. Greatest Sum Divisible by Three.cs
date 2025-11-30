public class Solution {
    public int MaxSumDivThree(int[] nums) {
        int sum = 0;
        
        List<int> rem1 = new List<int>();
        List<int> rem2 = new List<int>();

        foreach (int num in nums) {
            sum += num;

            int r = num % 3;
            if (r == 1) {
                rem1.Add(num);
                rem1.Sort();
                if (rem1.Count > 2) rem1.RemoveAt(2);
            }
            else if (r == 2) {
                rem2.Add(num);
                rem2.Sort();
                if (rem2.Count > 2) rem2.RemoveAt(2);
            }
        }

        if (sum % 3 == 0)
            return sum;

        int ans = 0;

        if (sum % 3 == 1) {
            int remove1 = rem1.Count > 0 ? rem1[0] : int.MaxValue;
            int remove2 = rem2.Count > 1 ? rem2[0] + rem2[1] : int.MaxValue;
            ans = sum - Math.Min(remove1, remove2);
        }
        else { // sum % 3 == 2
            int remove1 = rem2.Count > 0 ? rem2[0] : int.MaxValue;
            int remove2 = rem1.Count > 1 ? rem1[0] + rem1[1] : int.MaxValue;
            ans = sum - Math.Min(remove1, remove2);
        }

        return ans < 0 ? 0 : ans;
    }
}