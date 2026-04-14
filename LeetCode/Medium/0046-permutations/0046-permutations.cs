public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var res = new List<IList<int>>();
        Backtrack(nums, new List<int>(), new bool[nums.Length], res);
        return res;
    }
    
    private void Backtrack(int[] nums, List<int> cur, bool[] used, List<IList<int>> res) {
        if (cur.Count == nums.Length) {
            res.Add(new List<int>(cur));
            return;
        }

        for (int i = 0; i < nums.Length; i++) {
            if (used[i]) continue;
            used[i] = true;
            cur.Add(nums[i]);
            Backtrack(nums, cur, used, res);
            cur.RemoveAt(cur.Count - 1);
            used[i] = false;
        }
    }
}