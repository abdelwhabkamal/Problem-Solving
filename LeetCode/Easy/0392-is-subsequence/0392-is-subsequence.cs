public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length==0) return true;
        int c=0;
        for(int i=0;i<t.Length;i++){
            if(s[c]==t[i]){
                c++;
            }
            if(c==s.Length) return true;
        }
        return false;
    }
}