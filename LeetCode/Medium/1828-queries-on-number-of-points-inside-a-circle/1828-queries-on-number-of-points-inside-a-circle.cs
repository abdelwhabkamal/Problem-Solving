public class Solution {
    public int[] CountPoints(int[][] points, int[][] queries) {
        int q = queries.Length;
        int p = points.Length;
        int[] res = new int[q];
        for(int i = 0; i < q; i++){
            for(int j = 0; j < p; j++){
                if(Math.Pow((points[j][0])- (queries[i][0]), 2.0) 
                + Math.Pow((points[j][1])- (queries[i][1]), 2.0)
                <= Math.Pow(queries[i][2], 2.0)) res[i]++;
            }
        }
        return res;
    }
}