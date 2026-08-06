public class Solution {
    public int SmallestNumber(int n, int t) {
        int res = 1;
        int temp = n;
            while(temp > 0){
                res *= (temp % 10);
                temp /= 10;
            }
        Console.WriteLine(res);
        while(res % t != 0){
            temp = ++n;
            res = 1;
            while(temp > 0){
                res *= (temp % 10);
                temp /= 10;
            }
        }
        return n;
    }
}