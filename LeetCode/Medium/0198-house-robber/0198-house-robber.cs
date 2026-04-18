public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        if(n<=2) return nums.Max();
        int val1 = nums[0];
        int val2 = Math.Max(nums[1],val1);
        int ans = 0;
        for(int i=2 ; i<n ; i++){
            ans = Math.Max(val2 , nums[i] + val1);
            val1 = val2;
            val2 = ans; 
        }
        return ans;
    }
}