public class Solution {
    public int CountPartitions(int[] nums) {
        int sum = nums.Sum();
        int prefixSum = 0;
        int res = 0;
        for(int i = 0; i < nums.Length-1; i++){
            prefixSum += nums[i];
            sum -= nums[i];
            if(Math.Abs(prefixSum-sum) % 2 == 0) res++;
        }
        return res;
    }
}