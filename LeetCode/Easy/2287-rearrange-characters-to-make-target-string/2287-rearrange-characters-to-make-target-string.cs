public class Solution {
    public int RearrangeCharacters(string s, string target) {
        int[] s_freq = new int[26];
        foreach(char c in s){
            s_freq[c - 'a']++;
        }

        int[] t_freq = new int[26];
        foreach(char c in target){
            t_freq[c - 'a']++;
        }

        int res = int.MaxValue;
        for(int i = 0; i < 26; i++){
            if(t_freq[i] > 0){
                res = Math.Min(res , s_freq[i] / t_freq[i]);
            }
        }
        return res ;
    }
}