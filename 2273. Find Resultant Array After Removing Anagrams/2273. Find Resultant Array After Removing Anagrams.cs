namespace DefaultNamespace;
public class Solution {
    public IList<string> RemoveAnagrams(string[] words) {
        List<string> result = new List<string>();
        string prev = "";

        foreach (var word in words) {
            char[] arr = word.ToCharArray();
            Array.Sort(arr);
            string sorted = new string(arr);

            if (sorted != prev) {
                result.Add(word);
                prev = sorted;
            }
        }

        
        return result;
    }
}
