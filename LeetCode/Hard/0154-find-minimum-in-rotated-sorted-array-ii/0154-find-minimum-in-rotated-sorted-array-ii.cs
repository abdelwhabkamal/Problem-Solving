public class Solution {
    public int FindMin(int[] nums) {
        int l = 0;
        int r = nums.Length-1;
        if( nums[r] > nums[l]) return nums[l];
        while(l < nums.Length - 1 && nums[l] == nums[r]) l++;
        while(l<r){
            int mid = l + (r - l) / 2;
            if(nums[mid] <= nums[r] ) r = mid ;
            else l = mid + 1;
        } 
        return nums[l];
    }
}