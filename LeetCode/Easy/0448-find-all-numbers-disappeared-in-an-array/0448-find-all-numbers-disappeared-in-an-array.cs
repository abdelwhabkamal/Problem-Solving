public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        int n = nums.Length;
        var set = new HashSet<int>(nums);
        var result = new List<int>();

        for (int i = 1; i <= n; i++) {
            if (!set.Contains(i)) result.Add(i);
        }

        return result;
    }
}
