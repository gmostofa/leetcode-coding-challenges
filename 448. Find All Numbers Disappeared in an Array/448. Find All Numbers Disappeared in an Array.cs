namespace DefaultNamespace;

public class Solution 
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] > 0)
            {
                nums[index] = -nums[index];  
            }
        }

        List<int> result = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                result.Add(i + 1);
            }
        }

        return result;
    }

}