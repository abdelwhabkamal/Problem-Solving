public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int[] sub = new int[256]; 
        int longest = 0;
        int c = 0; 
        int l = 0; 

        for (int i = 0; i < s.Length; i++) {
            sub[s[i]]++;
            c++;

            while (sub[s[i]] > 1) {
                sub[s[l]]--;
                c--;
                l++;
            }

            longest = Math.Max(longest, c);
        }

        return longest;
    }
}
