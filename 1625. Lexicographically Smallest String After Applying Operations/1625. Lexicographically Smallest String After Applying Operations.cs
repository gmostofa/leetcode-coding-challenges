public class Solution {
    public string FindLexSmallestString(string s, int a, int b) {
        HashSet<string> visited = new HashSet<string>();
        Queue<string> queue = new Queue<string>();
        
        string smallest = s;
        queue.Enqueue(s);
        visited.Add(s);

        while (queue.Count > 0) {
            string curr = queue.Dequeue();
            if (String.Compare(curr, smallest) < 0)
                smallest = curr;

            // Operation 1: Add 'a' to digits at odd indices
            char[] chars = curr.ToCharArray();
            for (int i = 1; i < chars.Length; i += 2) {
                int digit = (chars[i] - '0' + a) % 10;
                chars[i] = (char)(digit + '0');
            }
            string added = new string(chars);

            // Operation 2: Rotate right by b
            string rotated = curr.Substring(curr.Length - b) + curr.Substring(0, curr.Length - b);

            if (!visited.Contains(added)) {
                visited.Add(added);
                queue.Enqueue(added);
            }
            if (!visited.Contains(rotated)) {
                visited.Add(rotated);
                queue.Enqueue(rotated);
            }
        }

        return smallest;
    }
}