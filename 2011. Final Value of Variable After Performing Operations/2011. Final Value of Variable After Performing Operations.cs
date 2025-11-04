
public class Solution 
{
    public int FinalValueAfterOperations(string[] operations) 
    {
        int x = 0;
        foreach (var op in operations) 
        {
            if (op.Contains("++"))
                x++;
            else
                x--;
        }

        return x;
    }
}