public class Solution {
    public string MapWordWeights(string[] words, int[] weights) {
        string res = "";
        for(int i = 0; i < words.Length; i++){
            int val = 0;
            foreach(char c in words[i]){
                val += weights[c - 'a'];
            }
            val %= 26;
            res += (char) (122 - val);
        }
        return res; 
    }
}