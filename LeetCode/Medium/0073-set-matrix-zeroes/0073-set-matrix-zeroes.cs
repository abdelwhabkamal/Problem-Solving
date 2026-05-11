public class Solution {
    public void SetZeroes(int[][] matrix) {
        List<int> zeros = new();
        int m = matrix[0].Length;
        int n = matrix.Length;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(matrix[i][j] == 0) zeros.Add((i * m) + j);
            }
        }
        for(int i = 0; i < zeros.Count; i++){
            int row = zeros[i] / m;
            int col = zeros[i] % m;
            for(int j = 0; j < m; j++){
                matrix[row][j] = 0;
            }  
            for(int j = 0; j < n; j++){
                matrix[j][col] = 0;
            }
        }
    }
}