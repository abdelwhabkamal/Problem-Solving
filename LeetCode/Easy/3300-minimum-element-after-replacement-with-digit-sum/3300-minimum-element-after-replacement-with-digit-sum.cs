public class Solution {
    public int MinElement(int[] nums) {
        int n = nums.Length;
        int min = int.MaxValue;
        for(int i = 0; i < n; i++){
            int cur = 0;
            while(nums[i] > 0){
                cur += nums[i]%10;
                nums[i] /= 10;
            }
            min = Math.Min(min , cur);
        }
        return min;
    }
}