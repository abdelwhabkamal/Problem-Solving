public class Solution {
    public int ConcatenatedBinary(int n) {
        long result = 0;
        long mod = 1000000007; 
        for(int i = 1; i <= n; i++)
        {
            int length = Convert.ToString(i, 2).Length;

            result = ((result << length) + i)%mod;
        }
        return (int)result;
    }
}