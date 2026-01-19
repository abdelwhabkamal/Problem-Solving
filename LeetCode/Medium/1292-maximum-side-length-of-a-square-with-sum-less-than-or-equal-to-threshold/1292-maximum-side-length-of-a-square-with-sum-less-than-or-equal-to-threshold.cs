public class Solution {
    public int MaxSideLength(int[][] mat, int threshold) {

        int m= mat.Length;
        int n=mat[0].Length;

        int[,] prefix= new int[m+1, n+1];

        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                prefix[i+1,j+1]=mat[i][j]+prefix[i,j+1]+prefix[i+1,j]-prefix[i,j];
            }
        }

        int maxSide=0;
        for(int i=1;i<=m;i++){
            for(int j=1;j<=n;j++){
                int nextLen=maxSide+1;
                if(i>=nextLen && j>=nextLen){
                    int r1=i-nextLen;
                    int c1=j-nextLen;

                    int currentSum= prefix[i,j]-prefix[r1,j]-prefix[i,c1]+prefix[r1,c1];

                    if(currentSum<=threshold) maxSide++;
                }
            }
        }
        return maxSide;
    }
}