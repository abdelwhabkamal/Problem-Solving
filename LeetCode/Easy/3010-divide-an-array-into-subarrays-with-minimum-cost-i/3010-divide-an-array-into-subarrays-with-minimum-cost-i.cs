public class Solution
{
    public int MinimumCost(int[] nums)
    {
        int f = int.MaxValue;
        int s = int.MaxValue;

        foreach (var num in nums.Skip(1))
        {
            s = Math.Min(s, Math.Max(f, num));
            f = Math.Min(f, num);
        }

        return nums[0] + f + s;
    }
}