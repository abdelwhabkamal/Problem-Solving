public class Solution {
    int res = 0;

    public int MinIncrements(int n, int[] cost) {
        Dfs(1, cost, n);
        return res;
    }

    int Dfs(int i, int[] cost, int n) {
        if (i > n) return 0;

        int left = Dfs(2 * i, cost, n);
        int right = Dfs(2 * i + 1, cost, n);

        res += Math.Abs(left - right);

        return cost[i - 1] + Math.Max(left, right);
    }
}
