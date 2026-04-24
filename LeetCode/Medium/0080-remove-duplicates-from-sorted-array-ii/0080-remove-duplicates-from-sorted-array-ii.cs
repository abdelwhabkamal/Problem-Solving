public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n = nums.Length;
        if(n <= 2) return n;
        int res  = 2;
        for(int i = 2; i < n ; i++){
            if(nums[i] != nums[res-2]){
                nums[res] = nums[i];
                res++;
            }
        }
        return res;
    }
}