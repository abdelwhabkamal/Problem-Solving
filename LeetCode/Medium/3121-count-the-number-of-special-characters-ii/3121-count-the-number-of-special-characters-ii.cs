public class Solution {
    public int NumberOfSpecialChars(string word) {
        int[] upper =  new int[26];
        int[] lower =  new int[26];
        for(int i = 0; i<word.Length; i++){
            if(word[i] > 96) lower[word[i] - 'a'] = i + 1;
            else {
                if(upper[word[i] - 'A'] == 0) upper[word[i] - 'A'] = i + 1;
            }
        }
        int res = 0;
        for(int i=0; i<26; i++){
            if (lower[i] > 0 && upper[i] > 0 && upper[i] > lower[i]) {
                res++;
            }
        }
        return res;
    }
}