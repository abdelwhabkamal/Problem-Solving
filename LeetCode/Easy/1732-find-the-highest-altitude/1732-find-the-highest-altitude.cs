public class Solution {
    public int LargestAltitude(int[] gain) {
        int res = 0;
        int cur = 0;
        foreach(int g in gain){
            cur += g;
            res = Math.Max(res , cur);
        }
        return res;
    }
}