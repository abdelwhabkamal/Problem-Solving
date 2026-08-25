public class Solution {
    public int CountGoodRectangles(int[][] rectangles) {
        int min = 0;
        int count = 0;
        foreach(int[] rec in rectangles){
            int curr = Math.Min(rec[0] , rec[1]);
            if(min == curr) count++;
            else if(curr > min) {
                min = curr;
                count = 1;
            }
        }
        return count;
    }
}