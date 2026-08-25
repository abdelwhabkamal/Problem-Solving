public class Solution {
    public int CountGoodRectangles(int[][] rectangles) {
        int min = Math.Min(rectangles[0][0] , rectangles[0][1]);
        int count = 1;
        for(int i = 1; i < rectangles.Length; i++){
            int curr = Math.Min(rectangles[i][0] , rectangles[i][1]);
            if(min == curr) count++;
            else if(curr > min) {
                min = curr;
                count = 1;
            }
        }
        return count;
    }
}