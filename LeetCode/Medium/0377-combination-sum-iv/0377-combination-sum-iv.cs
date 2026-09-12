public class Solution {
    public int CombinationSum4(int[] nums, int target) {
       Array.Sort(nums);
       Dictionary<int , int> dp = new();
       dp[target] = 1;
       for(int total = target; total > 0; total--){
            if(!dp.ContainsKey(total)) continue;
            foreach(int num in nums){
                if(total < num) break;
                if(!dp.ContainsKey(total - num)) dp[total - num] = 0;
                dp[total - num] += dp[total];
            }
       } 
       return dp.ContainsKey(0) ? dp[0] : 0;
    }
}