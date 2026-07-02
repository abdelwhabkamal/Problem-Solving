public class Solution {
    public bool ValidPalindrome(string s) {
        int l = 0;
        int r = s.Length - 1;
        bool flag = true;
        bool res = true;
        int new_l = 0;
        int new_r = 0;
        while(r >= l){
            if(!flag && s[l] != s [r]){
                res = false;
                break;
            }
            if(flag &&  s[l] != s [r]){
                new_l = l;
                new_r = r-1;
                l++;
                if(s[l] != s[r]){
                    res = false;
                    break;
                } 
                flag = false;
            }
            l++;
            r--;
        }

        if (res) return res;
        
        while(new_r >= new_l){
            if(s[new_r] != s[new_l]) return false;
            new_r--;
            new_l++;
        }
        
        return true;
    }
}