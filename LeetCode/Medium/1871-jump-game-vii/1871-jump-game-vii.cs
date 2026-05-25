public class Solution {
    public bool CanReach(string s, int minJump, int maxJump) {
        int n = s.Length;
        if (s[n - 1] == '1') return false;

        bool[] reach = new bool[n];
        reach[0] = true;

        int count = 0; 

        for (int i = 1; i < n; i++) {
            if (i >= minJump && reach[i - minJump]) count++;
            if (i > maxJump && reach[i - maxJump - 1]) count--;

            if (s[i] == '0' && count > 0) {
                reach[i] = true;
            }
        }

        return reach[n - 1];
    }
}
