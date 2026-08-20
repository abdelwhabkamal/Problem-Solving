public class Solution {
    public int[] ResultArray(int[] nums) {
        int[] arr2 = new int[nums.Length - 1];
        arr2[0] = nums[1];
        int l = 0;
        int r = 0;
        for(int i = 2; i < nums.Length; i++){
            if(nums[l] > arr2[r]) nums[++l] = nums[i];
            else arr2[++r] = nums[i];
        }
        for(int i = 0; i <= r; i++){
            nums[l+i+1] = arr2[i];
        }
        return nums;
    }
}