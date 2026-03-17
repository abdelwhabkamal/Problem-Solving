public class Solution {
    public int LargestSubmatrix(int[][] matrix) {
        int Y = matrix.Length;  
        int X = matrix[0].Length; 

        for (int x = 0; x < X; x++)        
            for (int y = 1; y < Y; y++)
                matrix[y][x] = matrix[y][x] == 0 ? 0 : matrix[y - 1][x] + 1;

        int res = 0;  
        for (int y = 0; y < Y; y++)
        {
            Array.Sort(matrix[y], (a, b) => b.CompareTo(a));            
            for (int x = 0; x < X; x++)
                res = Math.Max(res, (x + 1) * matrix[y][x]);
        }
        return res;
    }
}