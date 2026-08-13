public class Solution {
    public int MaxMoves(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        int[,] dp = new int[m , n];
        for (int i = 0; i < m; i++) {
            dp[i , 0] = 1;
        }

        int max = 0;
        for (int j = 1; j < n; j++) {
            for (int i = 0; i < m; i++) {
                if (grid[i][j] > grid[i][j - 1] && dp[i , j - 1] > 0) {
                    dp[i , j] = Math.Max(dp[i , j], dp[i , j - 1] + 1);
                }
                if (
                    i - 1 >= 0 &&
                    grid[i][j] > grid[i - 1][j - 1] &&
                    dp[i - 1 , j - 1] > 0
                ) {
                    dp[i , j] = Math.Max(dp[i , j], dp[i - 1 , j - 1] + 1);
                }
                if (
                    i + 1 < m &&
                    grid[i][j] > grid[i + 1][j - 1] &&
                    dp[i + 1 , j - 1] > 0
                ) {
                    dp[i , j] = Math.Max(dp[i , j], dp[i + 1 , j - 1] + 1);
                }

                max = Math.Max(max, dp[i , j] - 1);
            }
        }

        return max;
    }
}