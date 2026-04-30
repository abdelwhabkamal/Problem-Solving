public class Solution {
    public bool CanJump(int[] nums) {
        int n=nums.Length;
        if(n<2) return true;
        int jump = 0;
        for(int i = 0; i < n-1; i++){
            jump = Math.Max(jump - 1 ,  nums[i]);
            if(jump == 0) return false;
        }   
        return true;
    }
}