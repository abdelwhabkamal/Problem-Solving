public class Solution {
    public int ClimbStairs(int n) {
        if(n <= 3) return n;
        int prev = 2;
        int curr = 3;
        for(int i = 4; i < n; i++){
            int temp = prev;
            prev = curr;
            curr += temp;
        }
        return prev + curr;
    }
}