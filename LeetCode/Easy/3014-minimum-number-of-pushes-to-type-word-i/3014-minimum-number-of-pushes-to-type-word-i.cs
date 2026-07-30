public class Solution {
    public int MinimumPushes(string word) {
        int res = 0;
        for(int i = 0; i < word.Length; i++) res += (i / 8) + 1;
        return res;
    }
}