public class Solution {
    public long CountCommas(long n) {
        if(n < 1000) return 0;
        if(n < 1000000) return n - 999;
        if(n < 1000000000) return 999000 + (n - 999999) * 2;
        if(n < 1000000000000) return  1998999000 + (n - 999999999) * 3;
        if(n == 1000000000000000) return 3998998998999005;
        else return 2998998999000 +(n - 999999999999) * 4;
    }
}