public class Solution {
    public int MaximumLengthSubstring(string s) {
        int[] count = new int[26];
        int max = 0;
        int l = 0;

        for(int r = 0; r < s.Length; r++){
            count[s[r] - 'a']++;
            if(count[s[r] - 'a'] > 2){
                while(count[s[r] - 'a'] > 2) count[s[l++] - 'a']--;
            }
            max = Math.Max(max , r - l + 1);
        } 

        return max;
    }
}