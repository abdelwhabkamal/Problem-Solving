public class Solution {
    public int NumDistinct(string s, string t) {
        int n = s.Length;
        int m = t.Length;
        int[] dp = new int[m+1];
        dp[m] = 1;
        for(int i = n-1; i >= 0; i--){
            int prev = 1;
            for(int j = m-1; j >= 0; j--){
                int curr = dp[j];
                if(s[i] == t[j]) curr += prev;
                prev = dp[j];
                dp[j] = curr;
            }
        }
        return dp[0];
    }
}