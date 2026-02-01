public class Solution {
    public int MinimumCost(int[] nums) {
        int f = int.MaxValue;
        int s = int.MaxValue;

        for (var i = 1; i < nums.Length; i++)
        {
            if (f >= nums[i])
            {
                s = f;
                f = nums[i];
            }
            else if (s >= nums[i])
            {
                s = nums[i];
            }
        }

        return nums[0] + f + s;
    }
}