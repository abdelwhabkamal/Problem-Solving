public class Solution {
    public int StoneGameVIII(int[] stones) {
        int n = stones.Length;
        for(int i = 1; i < n; i++) stones[i] = stones[i-1] + stones[i];
        int res = stones[n-1];
        for(int i = n-2; i >= 1; i--) res = Math.Max(res , stones[i] - res);
        return res;
    }
}