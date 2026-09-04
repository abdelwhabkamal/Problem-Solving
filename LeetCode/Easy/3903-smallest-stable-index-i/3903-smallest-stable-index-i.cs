public class Solution {
    public int FirstStableIndex(int[] nums, int k) {
        int max = nums[0];
        int n = nums.Length;
        for(int i = 0; i < n; i++){
            max = Math.Max(max , nums[i]);
            int min = nums[i];
            for(int j = i+1; j < n; j++){
                min = Math.Min(min , nums[j]);
            }
            if(max - min <= k) return i;
        }
        return -1;
    }
}