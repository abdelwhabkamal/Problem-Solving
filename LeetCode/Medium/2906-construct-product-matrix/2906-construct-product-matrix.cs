public class Solution {
    // Time = Space + O(r*c), r,c = no of rows and cols in 'grid'
    public int[][] ConstructProductMatrix(int[][] g) {
        long prefix = 1, suffix = 1;
        int rows = g.Length, cols = g[0].Length, mod = 12345;
        int[][] p = new int[rows][];
        // first update the prefix product for each cell
        for(int r=0;r<rows;r++)
        {
            p[r] = new int[cols];
            for(int c=0;c<cols;c++)
            {
                p[r][c] = (int)prefix;
                prefix=(prefix * g[r][c]) % mod;
            }
        }
        // now iterating back multiply the prefix with suffix
        for(int r=rows-1;r>=0;r--)
            for(int c=cols-1;c>=0;c--)
            {
                p[r][c] = (int)((p[r][c]*suffix) % mod);
                suffix = (suffix * g[r][c]) % mod;
            }
        return p;
    }
}