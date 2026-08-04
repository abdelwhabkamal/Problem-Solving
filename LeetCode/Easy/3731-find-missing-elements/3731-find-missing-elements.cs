public class Solution {
    public IList<int> FindMissingElements(int[] nums) {

        Array.Sort(nums);
        List<int> res = new List<int>();

        for (int i = 1; i < nums.Length; i++) {
            int prev = nums[i - 1];
            int curr = nums[i];
            for (int j = prev + 1; j < curr; j++) {
                res.Add(j);
            }
        }

        return res;
    }
}
