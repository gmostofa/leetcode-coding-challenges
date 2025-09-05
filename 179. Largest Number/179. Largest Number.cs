using System;
using System.Linq;

public class Solution {
    public string LargestNumber(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return "";
        }
        
        // Convert integers to strings
        string[] strNums = nums.Select(n => n.ToString()).ToArray();
        
        // Custom sort: compare concatenated strings in reverse order
        Array.Sort(strNums, (a, b) => (b + a).CompareTo(a + b));
        
        // If the largest starts with '0', it's all zeros
        if (strNums[0] == "0") {
            return "0";
        }
        
        // Concatenate and return
        return string.Join("", strNums);
    }
}