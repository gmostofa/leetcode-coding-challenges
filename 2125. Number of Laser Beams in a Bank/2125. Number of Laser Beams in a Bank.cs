public class Solution 
{
    public int NumberOfBeams(string[] bank) 
    {
        int prev = 0;
        int total = 0;

        foreach (var row in bank) {
            int count = 0;
            foreach (var ch in row) {
                if (ch == '1') count++;
            }

            if (count > 0) {
                total += prev * count;
                prev = count;
            }
        }

        return total;
    }
}