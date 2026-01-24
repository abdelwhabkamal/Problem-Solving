public class Solution {
    public int MinPairSum(int[] nums) {
        Array.Sort(nums);
        int l= nums.Length;
        List<int> pairs= new();
        for(int i=0;i<l/2;i++){
            pairs.Add(nums[i]+nums[l-1-i]);
        }
        return pairs.Max();
    }
}