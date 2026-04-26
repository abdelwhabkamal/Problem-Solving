public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int res = 1;
        int c = 0;
        while(c < nums.Length-1){
            if(nums[c] != nums[c + 1]){
                nums[res] = nums[c + 1];
                res++;
            }
            c++;
        }
        return res;
    }
}
