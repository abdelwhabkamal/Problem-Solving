public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        if(n == 1) return nums[0];
        int[] rob = new int[n]; 
        rob[n - 1] = nums [n - 1];
        rob[n - 2] = Math.Max(nums [n - 1] , nums[n - 2]);
        for(int i = n - 3; i >=0; i--){
            rob[i] = Math.Max(nums[i] + rob[i + 2] , rob[i + 1]);
        }
        return rob[0];
    }
}