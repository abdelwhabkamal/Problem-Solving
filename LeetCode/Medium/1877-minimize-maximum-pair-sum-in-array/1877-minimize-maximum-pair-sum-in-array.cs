public class Solution {
    public int MinPairSum(int[] nums) {
        Array.Sort(nums);
        int l= nums.Length;
        int max_p=0;
        for(int i=0;i<l/2;i++){
            max_p=Math.Max(nums[i]+nums[l-1-i],max_p);
        }
        return max_p;
    }
}