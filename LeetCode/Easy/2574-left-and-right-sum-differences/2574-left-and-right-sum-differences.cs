public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        int n = nums.Length;
        int[] res = new int[n];
        int left = 0;
        for(int i = 1; i < n; i++){
            res[i] = res[i-1] + nums[i-1];
            left += res[i];
        }
        int right = 0;
        for(int i = n-2; i >= 0; i--){
            right += nums[i + 1];
            res[i] = Math.Abs(res[i] - right);
        }      

        return res;
    }
}