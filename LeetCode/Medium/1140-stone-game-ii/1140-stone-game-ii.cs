using System;
using System.Collections.Generic;

public class Solution {
    public int StoneGameII(int[] piles) {
        int n = piles.Length;

        int[] suffixSum = new int[n];
        suffixSum[n - 1] = piles[n - 1];
        for (int i = n - 2; i >= 0; i--) {
            suffixSum[i] = piles[i] + suffixSum[i + 1];
        }

        Dictionary<(int, int), int> memo = new();

        int Dfs(int i, int M) {
            if (i >= n) return 0;
            if (memo.ContainsKey((i, M))) return memo[(i, M)];

            int best = 0;
            for (int X = 1; X <= 2 * M && i + X <= n; X++) {
                best = Math.Max(best, suffixSum[i] - Dfs(i + X, Math.Max(M, X)));
            }

            memo[(i, M)] = best;
            return best;
        }
        return Dfs(0, 1);
    }
}
