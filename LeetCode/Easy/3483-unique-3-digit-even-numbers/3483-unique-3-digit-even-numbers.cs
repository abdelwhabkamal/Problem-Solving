public class Solution {
    public int TotalNumbers(int[] digits) {
        int[] count = new int[10];
        foreach (int d in digits) count[d]++;
    
        int res = 0;
        for(int num = 100; num < 1000; num+=2){
            int f = num %10;
            int s = (num/10) % 10;
            int t = num /100;
            count[f]--;
            count[s]--;
            count[t]--;
            if(count[f] >=0 && count[s] >=0 && count[t] >=0) res++;
            count[f]++;
            count[s]++;
            count[t]++;
        }
        return res;
    }
}