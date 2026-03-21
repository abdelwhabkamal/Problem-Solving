public class Solution {
    public int[][] ReverseSubmatrix(int[][] grid, int x, int y, int k) {
        for (int i = 0; i < (int)Math.Floor((float)k / 2); ++i)
        {
            for (int j = 0; j < k; ++j)
            {
                (grid[i + x][j + y], grid[k - i + x - 1][j + y]) = (grid[k - i + x - 1][j + y], grid[i + x][j + y]);
            }
        }

        return grid;
    }
}