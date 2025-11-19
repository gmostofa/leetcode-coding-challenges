namespace DefaultNamespace;
public class Solution 
{
    public string LargestGoodInteger(string num)
    {
        string maxTriplet = "";

        for (int i = 0; i <= num.Length - 3; i++)
        {
            if (num[i] == num[i + 1] && num[i] == num[i + 2])
            {
                string current = num.Substring(i, 3);
                if (string.Compare(current, maxTriplet) > 0)
                {
                    maxTriplet = current;
                }
            }
        }

        
        return maxTriplet;
    }
}