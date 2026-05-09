public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0, sum = 0;
        int min = int.MaxValue;
        
        for(int i = 0; i < nums.Length; i++){
            sum += nums[i];
            while( sum >= target){
                min = Math.Min(min , i - left + 1);
                sum -= nums[left];
                left++;
            }
        }
        return min != int.MaxValue ? min : 0;
    }
}