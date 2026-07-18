public class Solution {
    public int FindGCD(int[] nums) {
        int max = nums.Max();
        int min = nums.Min();
        int res = min;
        while(min > 0){
            if(max % res == 0 && min % res == 0) return res;
            res--;
        }
        return min;
    }
}