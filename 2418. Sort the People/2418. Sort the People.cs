namespace DefaultNamespace;

public class Solution 
{
    public string[] SortPeople(string[] names, int[] heights) 
    {
        var people = names
            .Select((name, index) => new { Name = name, Height = heights[index] })
            .OrderByDescending(p => p.Height) 
            .Select(p => p.Name)
            .ToArray();
        
        return people;
    }
}