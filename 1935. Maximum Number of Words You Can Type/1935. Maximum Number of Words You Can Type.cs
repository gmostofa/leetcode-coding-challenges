public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
        string[] words = text.Split(' ');
        HashSet<char> broken = new HashSet<char>(brokenLetters);

        int count = 0;
        foreach (string word in words) {
            bool canType = true;
            foreach (char c in word) {
                if (broken.Contains(c)) {
                    canType = false;
                    break;
                }
            }
            if (canType) count++;
        }

        return count;
    }
}