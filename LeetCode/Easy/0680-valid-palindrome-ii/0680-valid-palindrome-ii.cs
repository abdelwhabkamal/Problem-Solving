public class Solution {
    public bool ValidPalindrome(string s) {
        int l = 0, r = s.Length - 1;
        while (l < r) {
            if (s[l] != s[r]) {
                return IsPalindromeRange(s, l + 1, r) || IsPalindromeRange(s, l, r - 1);
            }
            l++;
            r--;
        }
        return true;
    }

    private bool IsPalindromeRange(string s, int l, int r) {
        while (l < r) {
            if (s[l] != s[r]) return false;
            l++;
            r--;
        }
        return true;
    }
}
