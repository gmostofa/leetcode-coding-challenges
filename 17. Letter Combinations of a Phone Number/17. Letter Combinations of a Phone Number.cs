public class Solution {
    private static readonly Dictionary<char, string> phoneMap = new() {
        {'2', "abc"}, {'3', "def"}, {'4', "ghi"}, {'5', "jkl"},
        {'6', "mno"}, {'7', "pqrs"}, {'8', "tuv"}, {'9', "wxyz"}
    };

    public IList<string> LetterCombinations(string digits) {
        List<string> result = new();

        if (string.IsNullOrEmpty(digits))
            return result;

        Backtrack(digits, 0, new StringBuilder(), result);
        return result;
    }

    private void Backtrack(string digits, int index, StringBuilder current, List<string> result) {
        if (index == digits.Length) {
            result.Add(current.ToString());
            return;
        }

        string letters = phoneMap[digits[index]];

        foreach (char c in letters) {
            current.Append(c);
            Backtrack(digits, index + 1, current, result);
            current.Remove(current.Length - 1, 1); // backtrack
        }
    }
}