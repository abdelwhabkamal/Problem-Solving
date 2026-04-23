public class Solution {
    public int MinOperations(int[] nums) {
        int n = nums.Length;
        int i = 0;
        int res = 0;
        while(i < n - 2){
            if( nums[i] == 0){
                nums[i] = 1;
                if(nums[i+1] == 0) nums[i+1] =  1;
                else nums[i+1] = 0;
                if(nums[i+2] == 0) nums[i+2] =  1;
                else nums[i+2] = 0;
                res++;
                i++;
            }
            else i++;
        }
        if(nums[n-1] == 0 || nums[n-2] == 0) return -1;
        return res;
    }
}