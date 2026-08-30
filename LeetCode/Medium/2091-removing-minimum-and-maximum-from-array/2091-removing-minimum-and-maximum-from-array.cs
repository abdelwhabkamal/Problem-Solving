public class Solution {
    public int MinimumDeletions(int[] nums) {
        int n = nums.Length;
        int min_i = 0;
        int max_i = 0;
        int min = nums[0];
        int max = nums[0];

        for(int i = 1; i < n; i++){
            if(nums[i] > max) {
                max = nums[i];
                max_i = i; 
            }
            if(nums[i] < min){
                min = nums[i];
                min_i = i;
            }
        }
        int far = Math.Max(max_i , min_i);
        int near = Math.Min(max_i , min_i);

        return Math.Min(far + 1, Math.Min(n - near,  (near + 1) + (n - far)));
    }
}