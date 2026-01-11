public class Solution {
    public int MaximalRectangle(char[][] matrix) {
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) {
            return 0;
        }
        
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int[] heights = new int[cols];
        int maxArea = 0;
        
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (matrix[i][j] == '1') {
                    heights[j]++;
                } else {
                    heights[j] = 0;
                }
            }
            Stack<int> stack = new Stack<int>();
            for (int j = 0; j <= cols; j++) {
                int h = (j == cols) ? 0 : heights[j];  
                while (stack.Count > 0 && heights[stack.Peek()] > h) {
                    int height = heights[stack.Pop()];
                    int width = stack.Count == 0 ? j : j - stack.Peek() - 1;
                    maxArea = Math.Max(maxArea, height * width);
                }
                if (j < cols) {
                    stack.Push(j);
                }
            }
        }       
        return maxArea;
    }
}