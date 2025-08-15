namespace DefaultNamespace;

public class Solution 
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach (var word in strs)
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }
            map[key].Add(word);
        }

        return new List<IList<string>>(map.Values);
    }

}