public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();
        res.Add(new List<int>());

        foreach (int num in nums) {
            int size = res.Count;
            for (int i = 0; i < size; i++) {
                List<int> subset = new(res[i]);
                subset.Add(num);
                res.Add(subset);
            }
        }

        return res;
    }
}