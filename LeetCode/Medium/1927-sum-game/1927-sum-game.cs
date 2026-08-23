public class Solution {
    public bool SumGame(string num) {
        int n = num.Length;
        int l = 0, r = 0, diff = 0;

        for (int i = 0; i < n; i++) {
            if (i < n / 2) {
                if (num[i] == '?') l++;
                else diff += num[i] - '0';
            } else {
                if (num[i] == '?') r++;
                else diff -= num[i] - '0';
            }
        }


        if ((r - l) % 2 == 0 && diff == (r - l) / 2 * 9) {
            return false;
        }
        return true;
    }
}
