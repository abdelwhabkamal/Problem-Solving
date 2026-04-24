public class Solution {
    public int CountPartitions(int[] nums) {
        int sum = 0;
        foreach(int num in nums){
            sum += num;
        }
        int prefixSum = 0;
        int res = 0;
        for(int i = 0; i < nums.Length-1; i++){
            prefixSum += nums[i];
            sum -= nums[i];
            if((prefixSum-sum) % 2 == 0) res++;
        }
        return res;
    }
}