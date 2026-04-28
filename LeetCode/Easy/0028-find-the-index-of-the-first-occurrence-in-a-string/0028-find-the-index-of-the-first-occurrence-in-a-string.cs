public class Solution {
    public int StrStr(string haystack, string needle) {
        int n = needle.Length;
        int h = haystack.Length;
        for(int i = 0; i < h; i++){
            if(haystack[i] == needle[0] && i + n <= h){
                int c = 1;
                for( int j = i+1; j < i+n; j++){
                    if(haystack[j] == needle[j-i]) c++;
                    else break;
                }
                if( c == n) return i;
            }
        }
        return -1;
    }
}