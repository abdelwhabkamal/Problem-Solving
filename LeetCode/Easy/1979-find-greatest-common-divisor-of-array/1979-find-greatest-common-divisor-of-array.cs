public class Solution {
    public int FindGCD(int[] nums) {
        int min = 1001;
        int max = 0;
        foreach(int n in nums){
            if(n > max) max = n;
            if(n < min) min = n;
        }
        int res = min;
        while(min > 0){
            if(max % res == 0 && min % res == 0) return res;
            res--;
        }
        return min;
    }
}