public class Solution {
    public int NumDecodings(string s) {
        int n = s.Length;
        if (n == 1 || s[0] == '0') {
            return s[0] >= '1' && s[0] <= '9' ? 1 : 0;
        }

        int[] dp = new int[n];

        int prev = s[0] - '0';
        int curr = s[1] - '0';

        dp[0] = 1;
        dp[1] = curr == 0 ? 0 : 1;
        dp[1] += prev * 10 + curr <= 26 ? 1 : 0;

        for(int i = 2; i < n; i++){
            prev = s[i - 1] - '0';
            curr = s[i] - '0';
            int num = prev *10 + curr;
            
            int sum = curr == 0 ? 0 : dp[i - 1];
            sum += (num >= 1 && num <= 26 && prev != 0 ? dp[i - 2] : 0);
            dp[i] = sum;
            if(dp[i] == 0) return 0;
        }
        return dp[n - 1];
    }
}