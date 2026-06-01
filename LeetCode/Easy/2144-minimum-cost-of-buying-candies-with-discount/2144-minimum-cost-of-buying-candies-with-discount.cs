public class Solution {
    public int MinimumCost(int[] cost) {
        int n = cost.Length;
        if(n <= 2) return cost.Sum();
        cost.Sort();
        int res = 0;
        int c = 0;
        for(int i = n-1; i >= 0; i--){
            if(c == 2) c = 0;
            else {
                c++;
                res += cost[i];
            }
        }
        return res;
    }                        
}         