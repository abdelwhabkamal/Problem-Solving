public class Solution {
    public string MapWordWeights(string[] words, int[] weights) {
        StringBuilder res = new();
        for(int i = 0; i < words.Length; i++){
            int val = 0;
            foreach(char c in words[i]){
                val += weights[c - 'a'];
            }
            val %= 26;
            res.Append((char) (122 - val));
        }
        return res.ToString(); 
    }
}