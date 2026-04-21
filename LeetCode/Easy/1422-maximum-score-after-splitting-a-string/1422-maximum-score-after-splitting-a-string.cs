public class Solution {
    public int MaxScore(string s) {
        int ones = 0;
        foreach(char c in s){
            if(c == '1') ones++;
        }
        int ans = 0;
        int zeros = 0;
        for(int i = 0; i < s.Length -1; i++){
            if(s[i] == '0'){
                zeros++;
            }
            else ones--;
            ans = Math.Max(ans , ones + zeros);
        }
        return ans;
    }
}