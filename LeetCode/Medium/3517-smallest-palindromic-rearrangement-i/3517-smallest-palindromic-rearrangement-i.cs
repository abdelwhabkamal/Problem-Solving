public class Solution {
    public string SmallestPalindrome(string s) {
        int[] count = new int[26];
        foreach(char c in s) count[c - 'a']++;
        char[] res = new char[s.Length];
        int ind = 0;
        for(int i = 0; i < 26; i++){
            if(count[i] > 0 && count[i] % 2 != 0){
                res[s.Length / 2  ] = (char) ('a' + i);
                count[i]--;
            }
            if(count[i] > 0){
                while(count[i] > 0){
                    res[ind] = (char) ('a' + i);
                    res[s.Length - ind - 1] = (char)('a' + i);
                    count[i] -= 2;
                    ind++;
                }
            }
        }
        return new string(res);
    }
}