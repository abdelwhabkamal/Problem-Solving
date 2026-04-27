public class Solution {
    public int LengthOfLastWord(string s) {
        int res = 0;
        int n = s.Length-1;

        while(n >= 0 && s[n] == ' '){
            n--;
        } 
        
        for(int i = n; i >= 0; i--){
            if(s[i] == ' ') break;
            res++;
        }
        return res;
    }
}
