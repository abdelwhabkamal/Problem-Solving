public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length;
        int l = 0;
        int r = n-1;
        int mid = 0;
        while(l<r){
            mid = l + (r - l) / 2;
            if(nums[mid] < nums[r]) r = mid;
            else l = mid + 1;
        } 
        r = l + n - 1;
        while(r>=l){
            mid = l + (r - l) / 2;
            if(nums[(mid+n) % n] == target) return (mid+n) % n;
            if( nums[(mid+n) % n] > target) r = mid -1;
            else l = mid + 1;
        } 
        return -1;
    }
}
