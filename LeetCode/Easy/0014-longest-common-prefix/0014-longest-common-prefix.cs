public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int minLength = strs.Min(s => s.Length); 
        StringBuilder commonPrefix = new();

        for (int i = 0; i < minLength; i++) {
            char currentChar = strs[0][i]; 

            if (strs.All(s => s[i] == currentChar)) {
                commonPrefix.Append(currentChar);
            } else {
                break; 
            }
        }

        return commonPrefix.ToString();
    }
}