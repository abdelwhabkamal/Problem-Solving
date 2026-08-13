public class Solution {
    public string LongestPalindrome(string s) {
        int start = 0;
        int maxLength = 1;   
        for (int i = 0; i < s.Length; i++) {
            int oddLength = ExpandFromCenter(s, i, i);
            int evenLength = ExpandFromCenter(s, i, i + 1);
            
            int length = Math.Max(oddLength, evenLength);
            
            if (length > maxLength) {
                maxLength = length;
                start = i - (length - 1) / 2;
            }
        }
        
        return s.Substring(start, maxLength);
    }
    
    int ExpandFromCenter(string s, int left, int right) {
        while (left >= 0 && right < s.Length && s[left] == s[right]) {
            left--;
            right++;
        }
    
        return right - left - 1;
    }
}