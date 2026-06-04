public class Solution {
    public int TotalWaviness(int num1, int num2) {
        if(num2 < 101) return 0;
        if(num1 < 101) num1 = 101;
        int res = 0;
        for(int i = num1; i <= num2; i++){
            string s = i.ToString();
            for(int j = 1; j < s.Length-1; j++){
                if(s[j] > s[j-1] && s[j] > s[j+1]) res++;
                if(s[j] < s[j-1] && s[j] < s[j+1]) res++;
            }
        }
        return res;
    }
}