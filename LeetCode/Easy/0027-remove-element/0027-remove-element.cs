public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int res=0;
        for(int n=0; n< nums.Length;n++){
            if(nums[n]!=val){
                nums[res]=nums[n];
                res++;                
            }
        }
        return res;
    }
}