public class Solution 
{
    public IList<IList<int>> Subsets(int[] nums) 
    {
        List<IList<int>> result = new List<IList<int>>();
        List<int> current = new List<int>();

        
        void Backtrack(int start) 
        {
            result.Add(new List<int>(current));
            for (int i = start; i < nums.Length; i++) {
                // Choose
                current.Add(nums[i]);
                // Explore
                Backtrack(i + 1);
                // Un-choose (backtrack)
                current.RemoveAt(current.Count - 1);
            }
        }

        Backtrack(0);
        return result;
    }
}