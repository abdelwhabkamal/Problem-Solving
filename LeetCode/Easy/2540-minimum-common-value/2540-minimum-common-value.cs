public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        int l = 0;
        int r = 0;
        while( l < nums1.Length && r < nums2.Length){
            if(nums2[r] == nums1[l]) return nums2[r];
            else if(nums2[r] > nums1[l]) l++;
            else r++;
        }
        return -1;
    }
}