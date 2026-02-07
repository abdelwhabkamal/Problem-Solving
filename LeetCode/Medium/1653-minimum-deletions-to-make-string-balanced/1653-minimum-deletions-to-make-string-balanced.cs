public class Solution {
    public int MinimumDeletions(string s) {
        int b = 0;
        int ans = 0;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='b')b++;
            else{
                ans=Math.Min(ans+1,b);
            }
        }
        return ans;
    }
}