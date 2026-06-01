public class Solution {
    public int MinimumCost(int[] cost) {
        cost.Sort();
        int res = 0;
        for(int i = cost.Length-1; i >= 0; i-=3){
            res += cost[i];
            if( i-1 >= 0) res += cost[i-1];
        }
        return res;
    }                        
}         