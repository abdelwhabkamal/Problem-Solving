public class Solution {
    public void SetZeroes(int[][] matrix) {
        int m = matrix[0].Length;
        int n = matrix.Length;
        bool[] rows = new bool[n];
        bool[] cols = new bool[m];
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(matrix[i][j] == 0){
                    rows[i] = true;
                    cols[j] = true;
                }
            }
        }
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(rows[i] || cols[j]){
                    matrix[i][j] = 0;
                }
            }  
        }
    }
}