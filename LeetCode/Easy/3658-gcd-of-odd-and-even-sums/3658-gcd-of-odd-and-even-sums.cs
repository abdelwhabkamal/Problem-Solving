public class Solution {
    public int GcdOfOddEvenSums(int n) {
        int e = 2;
        int o = 1;
        for(int i = 3; i <= n*2; i+=2){
            e += i+1;
            o += i; 
        }
        while (e != 0){
            int temp = e;
            e = o % e;
            o = temp;
        }
        return o;
    }
}