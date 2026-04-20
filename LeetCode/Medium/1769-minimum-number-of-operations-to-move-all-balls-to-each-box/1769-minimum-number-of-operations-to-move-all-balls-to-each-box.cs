public class Solution {
    public int[] MinOperations(string boxes) {
        int[] ans=new int[boxes.Length];
        for(int i=0;i<boxes.Length;i++){
            for(int j=0;j<boxes.Length;j++){
                if(boxes[j]=='1') ans[i]+=Math.Abs(i-j);
            }
        }
        return ans;
    }
}