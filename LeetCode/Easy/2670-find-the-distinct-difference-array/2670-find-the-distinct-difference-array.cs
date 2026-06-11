public class Solution {
    public int[] DistinctDifferenceArray(int[] nums) {
        int[] suff = new int[51];
        for(int i = 0; i < nums.Length; i++){
            suff[nums[i]]++;
        }
        int s = 0;
        for(int i = 1; i <= 50; i++){
            if(suff[i] > 0) s++;
        }
        int[] pref = new int[51];
        int p = 0;
        int[] res = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            if(pref[nums[i]]++ == 0) p++;
            if(--suff[nums[i]] == 0) s--;
            res[i] = p - s;
        }
        return res;
    }
}