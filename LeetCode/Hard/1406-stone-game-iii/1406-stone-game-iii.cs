public class Solution {
    public string StoneGameIII(int[] stoneValue) {
        int n = stoneValue.Length;
        int[] dp = new int[3];

        for (int i = n - 1; i >= 0; i--)
        {
            int take1 = stoneValue[i] - dp[(i + 1) % 3];

            int take2 = int.MinValue;
            if ((i + 1) < n)
                take2 = stoneValue[i] + stoneValue[i + 1] - dp[(i + 2) % 3];

            int take3 = int.MinValue;
            if ((i + 2) < n)
                take3 = stoneValue[i] + stoneValue[i + 1] + stoneValue[i + 2] - dp[(i + 3) % 3];

            dp[i % 3] = Math.Max(take1, Math.Max(take2, take3));
        }

        if (dp[0] > 0)
            return "Alice";
        else if (dp[0] < 0)
            return "Bob";
        else
            return "Tie";
    }
}