public class Solution {
    public int[] ResultArray(int[] nums) {
        List<int> arr2 = new();
        arr2.Add(nums[1]);
        int l = 0;
        int r = 0;
        for(int i = 2; i < nums.Length; i++){
            if(nums[l] > arr2[r]) nums[++l] = nums[i];
            else {
                arr2.Add(nums[i]);
                r++;
            }
        }
        for(int i = 0; i <= r; i++){
            nums[l+i+1] = arr2[i];
        }
        return nums;
    }
}