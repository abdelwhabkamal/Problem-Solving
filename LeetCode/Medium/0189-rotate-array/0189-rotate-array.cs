public class Solution {
    public void Rotate(int[] nums, int k) {
        k %= nums.Length;
        int l = nums.Length - k;
        int r = k;
        Array.Reverse(nums,l,r);
        l = 0;
        r = nums.Length - k;
        Array.Reverse(nums,l,r);
        l=0;
        r = nums.Length;
        Array.Reverse(nums,l,r);
    }
}