public class Solution {
    public bool IsPalindrome(string s) {
        int r=s.Length-1;
        int l=0;
        while(r>l){
            while(!char.IsLetterOrDigit(s[l]))l++;
            while(!char.IsLetterOrDigit(s[r]))r--;
            if(char.ToLower(s[r]) != char.ToLower(s[l]))return false;
            l++;
            r--;
        }
        return true;
    }
}
