public class Solution {
    public int MinimumCost(int[] cost) {
        int n = cost.Length;
        if(n <= 2) return cost.Sum();
        cost.Sort();
        int res = 0;
        for(int i = n-1; i >= 0; i-=3){
            res += cost[i];
            if( i-1 >= 0) res += cost[i-1];
        }
        return res;
    }                        
}         