public class Solution {
    public int MinimumCost(int[] nums) {
        int t=nums[0];
        Array.Sort(nums);
        int f=nums[0];
        int s=nums[1];
        if(f != t && s != t)
            return f+s+t;
        else
            return f+s+nums[2];
    }
}