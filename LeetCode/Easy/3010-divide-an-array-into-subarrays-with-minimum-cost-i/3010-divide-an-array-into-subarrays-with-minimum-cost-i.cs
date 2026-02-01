public class Solution {
    public int MinimumCost(int[] nums) {
        int t=nums[0];
        Array.Sort(nums);
        if(nums[0] != t && nums[1] != t)
            return nums[0]+nums[1]+t;
        else
            return nums[0]+nums[1]+nums[2];
    }
}