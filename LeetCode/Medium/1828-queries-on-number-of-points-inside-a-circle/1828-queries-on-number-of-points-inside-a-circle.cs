public class Solution {
    public int[] CountPoints(int[][] points, int[][] queries) {
        int q = queries.Length;
        int p = points.Length;
        int[] res = new int[q];
        for(int i = 0; i < q; i++){
            for(int j = 0; j < p; j++){
                if( (points[j][0]- queries[i][0]) * ( points[j][0] - queries[i][0]) 
                + (points[j][1] - queries[i][1]) * (points[j][1] - queries[i][1])
                <= queries[i][2] * queries[i][2]) res[i]++;
            }
        }
        return res;
    }
}