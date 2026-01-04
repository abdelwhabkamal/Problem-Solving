public class Solution {
    public int CountTriples(int n) {
        int ans =0;
        for(int a=3;a<=n;a++){
            for(int b=a+1;b<=n;b++){
                int c = (int)Math.Sqrt(a * a + b * b + 1.0);
                if (c <= n && c * c == a * a + b * b) {
                    ans+=2;
                }
            }
        }
        return ans;
    }
}