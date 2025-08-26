public class Solution
{
    private static readonly HashSet<int> Perfects = new()
    {
        6, 28, 496, 8128, 33550336
    };

    public bool CheckPerfectNumber(int num) => Perfects.Contains(num);
}