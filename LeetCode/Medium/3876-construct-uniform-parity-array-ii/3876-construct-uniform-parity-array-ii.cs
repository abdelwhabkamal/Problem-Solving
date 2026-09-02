public class Solution {
    public bool UniformArray(int[] nums1) {
        int max_odd = -1;
        int max_even = -1;
        int min_even = int.MaxValue;
        foreach(int num in nums1) {
            if(num %2 == 0) {
                max_even = Math.Max(max_even , num);
                min_even = Math.Min(min_even , num);
                }
            else max_odd = Math.Max(max_odd , num);
        }
        if(max_odd == -1 || max_even == -1) return true;
        foreach(int num in nums1){
            if(num %2 != 0 && num < min_even) return true;
        }
        return false;
    }
}