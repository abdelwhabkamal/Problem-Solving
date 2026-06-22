public class Solution {
    public int MaxNumberOfBalloons(string text) {
        int[] freq = new int[26];
        foreach(char c in text){
            freq[c - 'a']++;
        }
        int res = Math.Min(freq[0] ,Math.Min(freq[1] , Math.Min(freq['l'-'a'] / 2 , Math.Min(freq['n' - 'a'] , freq['o' - 'a'] / 2))));
        return res ;
    }
}