public class Solution {
    public int MinOperations(string s) {
        int start0 = 0;
        
        for (int i = 0; i < s.Length; i++) {
            if (i % 2 == 0) {
                if (s[i] == '1') {
                    start0++;
                }
            } else {
                if (s[i] == '0') {
                    start0++;
                }
            }
        }
        
        return Math.Min(start0, s.Length - start0);
    }
}