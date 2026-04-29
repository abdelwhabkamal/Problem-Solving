public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n = nums.Length;
        if(n <= 2) return n;
        int k = 2;
        for(int i = 2; i < n; i++){
            if(nums[i] != nums[k-2]){
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}