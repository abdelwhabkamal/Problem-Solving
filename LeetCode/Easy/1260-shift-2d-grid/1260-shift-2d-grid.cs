public class Solution {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
        int m = grid.Length;
        int n = grid[0].Length;
        int[][] res = new int[m][];
        for (int i = 0; i < m; i++) {
            res[i] = new int[n];
        }
        int co = 0;
        for(int i = k; i < k +( m * n); i++){
            int c = (i % (m * n)) % n;
            int r = (i % (m * n)) / n;
            res[r][c] = grid[co / n][co % n];
            co++;
        }
        return res;
    }
}