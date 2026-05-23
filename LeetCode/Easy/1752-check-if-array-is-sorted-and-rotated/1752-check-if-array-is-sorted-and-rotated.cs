public class Solution {
    public bool Check(int[] nums) {
        int n = nums.Length;
        int l = 0;
        int r = n-1;
        int min = 0;
        if( nums[r] > nums[l]) min = nums[l];
        while(l < n - 1 && nums[l] == nums[r]) l++;
        while(l<r){
            int mid = l + (r - l) / 2;
            if(nums[mid] <= nums[r] ) r = mid ;
            else l = mid + 1;
        } 
        min = nums[l];
        if(nums.Min() != min) return false;
        for(int i = l; i < l+n-1; i++){
            if(nums[ (i + n) % n] > nums[ (i + 1 + n) % n]) return false;
        }
        return true;
    }
}