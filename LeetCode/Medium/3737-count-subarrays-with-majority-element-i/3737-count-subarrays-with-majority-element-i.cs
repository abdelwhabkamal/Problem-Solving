public class Solution {
    public int CountMajoritySubarrays(int[] nums, int target) {
        int n = nums.Length;
        int[] balance = new int[n + 1];
        
        for (int i = 0; i < n; i++) {
            balance[i + 1] = balance[i] + (nums[i] == target ? 2 : 0) - 1;
        }

        var sorted = balance.Distinct().OrderBy(x => x).ToList();
        var indexMap = new Dictionary<int, int>();
        for (int i = 0; i < sorted.Count; i++) indexMap[sorted[i]] = i + 1; 

        int[] bit = new int[sorted.Count + 2];
        int res = 0;

        void Update(int idx) {
            while (idx < bit.Length) {
                bit[idx]++;
                idx += idx & -idx;
            }
        }

        int Query(int idx) {
            int sum = 0;
            while (idx > 0) {
                sum += bit[idx];
                idx -= idx & -idx;
            }
            return sum;
        }

        foreach (var b in balance) {
            int idx = indexMap[b];
            res += Query(idx - 1);
            Update(idx);
        }

        return res;
    }
}
