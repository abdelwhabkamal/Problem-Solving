public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        int sum = 0;
        for(int i = 0; i < nums.Length; i++){
            sum += nums[i];
        }
        int cur = 0;
        int prev = 0;
        for(int i = 0; i < nums.Length; i++){
            prev = cur;
            cur += nums[i];
            nums[i] = Math.Abs(cur + prev - sum);
        }      

        return nums;
    }
}