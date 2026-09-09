public class Solution {
    public long CountCommas(long n) {
        if (n < 1000) return 0;
        long result = 0;
        long start = 1000;
        int commas = 1;

        while (true) {
            long end = start * 1000 - 1; 
            if (n <= end) {
                result += (n - start + 1) * commas;
                break;
            } else {
                result += (end - start + 1) * commas;
                start *= 1000;
                commas++;
            }
        }

        return result;
    }
}
