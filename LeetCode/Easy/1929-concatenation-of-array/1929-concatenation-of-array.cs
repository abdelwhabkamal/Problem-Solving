public class Solution {
    public int[] GetConcatenation(int[] nums) {
        List<int> ans=new();
        ans.AddRange(nums);
        ans.AddRange(nums);
        return ans.ToArray();
    }
}