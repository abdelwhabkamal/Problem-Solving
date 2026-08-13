public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        if(n == 1) return nums[0];
        if(n == 2) return Math.Max(nums[0] , nums[1]);
        int[] left = new int[n - 1]; 
        left[n - 2] = nums[n - 1];
        left[n - 3] = Math.Max(nums[n - 1] , nums[n - 2]);
        for(int i = n - 4; i >=0; i--){
            left[i] = Math.Max(nums[i + 1] + left[i + 2] , left[i + 1]);
        }
        int[] right = new int[n - 1]; 
        right[0] = nums[0];
        right[1] = Math.Max(nums[0] , nums[1]);
        for(int i = 2; i < n - 1; i++){
            right[i] = Math.Max(nums[i] + right[i - 2] , right[i - 1]);
        }
        return Math.Max(left[0] , right[n - 2]);
    }
}