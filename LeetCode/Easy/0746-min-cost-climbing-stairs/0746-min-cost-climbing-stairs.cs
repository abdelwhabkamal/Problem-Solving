public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;
        int oneStep = cost[n - 1];  
        int twoSteps = 0;           
        for (int i = n - 2; i >= 0; i--) {
            int current = cost[i] + Math.Min(oneStep, twoSteps);
            twoSteps = oneStep;
            oneStep = current;
        }

        return Math.Min(oneStep, twoSteps);
    }
}
