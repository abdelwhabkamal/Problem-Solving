public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n=nums.Length;
        int[] pref=new int[n];
        int[] suf=new int[n];
        pref[0]=1;
        suf[n-1]=1;
        for( int i = 0; i < n-1; i++){
            pref[i + 1] = nums[i] * pref[i];
            suf[n-2-i] = nums[n-i-1] * suf[n-i-1]; 
        }
        for(int i = 0; i < n; i++){
            nums[i] = pref[i] * suf[i];
        }
        return nums;        
    }
}