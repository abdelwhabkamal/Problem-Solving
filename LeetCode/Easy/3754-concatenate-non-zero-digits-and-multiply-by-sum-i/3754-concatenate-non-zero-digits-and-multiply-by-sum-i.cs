public class Solution {
    public long SumAndMultiply(int n) {
        StringBuilder sn = new();
        int sum = 0; 
        long res = 0; 
        int mult =1;
        while(n > 0){
            if(n % 10 != 0){
                sum += n%10;
                res += (mult * (n%10));
                mult *= 10;
            }
            n /= 10;
        }
        res *= sum;
        return res;
    }
}