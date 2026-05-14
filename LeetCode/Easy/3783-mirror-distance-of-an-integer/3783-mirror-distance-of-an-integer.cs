public class Solution {
    public int MirrorDistance(int n) {
        int rev = 0;
        int temp = n;
        while (temp > 0) {
            rev = (rev * 10) + (temp % 10);
            temp /= 10;
        }
        return Math.Abs(n - rev);
    }
}