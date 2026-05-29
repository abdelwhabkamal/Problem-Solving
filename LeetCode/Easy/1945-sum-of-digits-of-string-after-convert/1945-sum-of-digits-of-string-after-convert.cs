public class Solution {
    public int GetLucky(string s, int k) {
        int ans = 0;
        for(int i = 0; i < s.Length; i++){
            int cur =  s[i] - 'a' + 1;
            while(cur > 0){
                ans += cur %10;
                cur /= 10;
            }
        }
        for(int i = 1; i < k; i++){
            if(ans < 10) return ans;
            int cur = 0;
            while(ans > 0){
                cur += ans %10;
                ans /= 10;
            }
            ans = cur;
        }
        return ans;
    }
}