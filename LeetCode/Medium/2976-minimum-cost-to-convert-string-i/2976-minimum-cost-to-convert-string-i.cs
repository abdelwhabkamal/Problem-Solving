public class Solution {
    public long MinimumCost(string source, string target, char[] original, char[] changed, int[] cost) {
        long res = 0;
        int cLen = 26;
        int len = original.Length;
        
        // init dp:
        long[,] dp = new long[cLen, cLen];
        for(int i = 0; i < cLen; i++)
        {
            for(int j = 0; j < cLen; j++)
            {
                dp[i,j] = int.MaxValue;
            }

            dp[i,i] = 0;
        }

        for(int i = 0; i < len; i++)
        {
            int from = original[i]-'a', to = changed[i] - 'a';
            if(cost[i] < dp[from, to])
                dp[from, to] = cost[i];
        }

        for(int k = 0; k < cLen; k++)
        {
            for(int i = 0; i < cLen; i++)
            {
                for(int j = 0; j < cLen; j++)
                {
                    long pre = dp[i,k]+ dp[k,j];
                    if(pre < dp[i,j])
                        dp[i,j] = pre;
                }
            }
        }

        int idx = 0;
        while(idx <source.Length)
        {
            if(source[idx] != target[idx])
            {
                int from = source[idx] - 'a', to = target[idx]-'a';
                if(dp[from,to] == int.MaxValue)
                    return -1;
                    
                res += dp[from, to];
            }

            idx++;
        }

        return res;
    }
}