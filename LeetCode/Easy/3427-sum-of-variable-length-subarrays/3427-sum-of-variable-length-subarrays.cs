public class Solution {
    public int SubarraySum(int[] nums) {
        int res = 0;
        int n = nums.Length;
        int[] prefix = new int[n + 1];
        for(int i = 0; i < n; i++){
            prefix[i+1] = prefix[i] + nums[i];
        }
        for(int i = 0; i < nums.Length; i++){
            int start = Math.Max(0 , i - nums[i]);
            res += prefix[i+1] - prefix[start];
        }
        return res;
    }
}