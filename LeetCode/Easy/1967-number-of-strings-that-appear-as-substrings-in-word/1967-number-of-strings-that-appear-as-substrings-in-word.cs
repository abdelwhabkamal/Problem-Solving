public class Solution {
    public int NumOfStrings(string[] patterns, string word) {
        int res = 0;
        foreach (string p in patterns) {
            if (word.Contains(p)) res++;
        }
        return res;
    }
}
