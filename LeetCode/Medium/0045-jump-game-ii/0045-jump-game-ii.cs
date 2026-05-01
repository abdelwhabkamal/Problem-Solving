public class Solution {
    public int Jump(int[] nums) {
        int n=nums.Length;
        if(n<2) return 0;
        int steps = 1;
        int current = nums[0];
        int l = 0;
        while(current < n-1){
            int max = 0;
            for(int i = l; i <= current; i++){
                max = Math.Max(max , i + nums[i]);
            }
            l = current + 1;
            current = max;
            steps++;
        }
        return steps;
    }
}