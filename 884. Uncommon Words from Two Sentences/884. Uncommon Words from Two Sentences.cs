namespace DefaultNamespace;

public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {
        string combined = s1 + " " + s2;
        string[] words = combined.Split(' ');

        Dictionary<string, int> freq = new Dictionary<string, int>();

        foreach (string word in words) {
            if (freq.ContainsKey(word)) {
                freq[word]++;
            } else {
                freq[word] = 1;
            }
        }

        List<string> result = new List<string>();
        foreach (var kvp in freq) {
            if (kvp.Value == 1) {
                result.Add(kvp.Key);
            }
        }

        return result.ToArray();
    }
}
