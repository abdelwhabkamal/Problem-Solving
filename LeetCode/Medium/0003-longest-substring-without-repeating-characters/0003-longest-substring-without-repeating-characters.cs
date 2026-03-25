public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> sub= new();
        int longest=0;
        int l=0;
        int r=0;
        while(r<s.Length){
            if(sub.Contains(s[r])){
                sub.Remove(s[l]);
                l++;
            }
            else{
                sub.Add(s[r]);
                r++;
                longest=Math.Max(longest,r-l);
            }
        }
        return longest;
    }
}