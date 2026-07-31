public class Solution {
    public int MinimumPushes(string word) {
        int[] cnt = new int[26];
        foreach(char c in word) cnt[c - 'a']++;
        Array.Sort(cnt);
        int res = 0;
        int ind = 0;
        for(int i = 25; i >= 0; i--){
            if(cnt[i] == 0) return res;
            res += ((ind / 8) + 1) * cnt[i];
            ind++;
        }
        return res;
    }
}