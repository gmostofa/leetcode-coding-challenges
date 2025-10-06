namespace DefaultNamespace;

public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] words = s.Split(' ');
        if (pattern.Length != words.Length) return false;

        Dictionary<char, string> charToWord = new Dictionary<char, string>();
        Dictionary<string, char> wordToChar = new Dictionary<string, char>();

        for (int i = 0; i < pattern.Length; i++) {
            char c = pattern[i];
            string w = words[i];

            if (charToWord.ContainsKey(c)) {
                if (charToWord[c] != w) return false;
            } else {
                charToWord[c] = w;
            }

            if (wordToChar.ContainsKey(w)) {
                if (wordToChar[w] != c) return false;
            } else {
                wordToChar[w] = c;
            }
        }

        return true;
    }
}
