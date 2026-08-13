public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        if(n <= 2) nums.Max();
        int[] rob = new int[n + 1]; 
        rob[n - 1] = nums [n - 1];
        for(int i = n - 2; i >=0; i--){
            rob[i] = Math.Max(nums[i] + rob[i + 2] , rob[i + 1]);
        }
        return rob[0];
    }
}