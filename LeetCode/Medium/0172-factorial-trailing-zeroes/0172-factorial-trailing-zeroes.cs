public class Solution {
    public int TrailingZeroes(int n) {
        int res = 0;
        int mul = 5; 
        while( (n/mul) > 0){
            res += (n / mul);
            mul *= 5;
        }
        return res;
    }
}