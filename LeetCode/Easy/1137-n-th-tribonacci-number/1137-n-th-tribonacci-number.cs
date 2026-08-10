public class Solution {
    public int Tribonacci(int n) {
        if(n == 0) return 0;
        if(n < 3) return 1;
        int f = 0;
        int s = 1;
        int t = 1;
        int res = 2;
        for(int i = 4; i <= n; i++){
            f = s;
            s = t;
            t = res; 
            res = f + s + t;
        } 
        return res;
    }
}