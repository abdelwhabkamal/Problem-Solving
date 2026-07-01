public class Solution {
    public void ReverseString(char[] s) {
        int n = s.Length;
        for(int i = 0; i < n/2 ; i++){
            s[i] ^= s[n - i - 1];
            s[n - i - 1] ^= s[i];
            s[i] ^= s[n - i - 1];
        }
    }
}