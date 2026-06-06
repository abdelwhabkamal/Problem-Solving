public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        int[] res = new int[nums.Length];
        int left = 0;
        for(int i = 1; i < nums.Length; i++){
            res[i] = res[i-1] + nums[i-1];
            left += res[i];
        }
        int right = 0;
        for(int i = nums.Length-2; i >= 0; i--){
            right += nums[i + 1];
            res[i] = Math.Abs(res[i] - right);
        }      

        return res;
    }
}