public class Solution {
    public int ClimbStairs(int n) {
        if(n <= 2) return n;
        int val1 = 1;
        int val2 = 2;
        int ans = 0;
        for(int i = 2; i < n; i++){
            ans = val1 + val2;
            val1 = val2;
            val2 = ans;
        }
        return ans;
    }
}