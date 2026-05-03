public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        if(gas.Sum() < cost.Sum()) return -1;
        int n = gas.Length;
        int tank = 0;
        int res = 0;
        for(int i = 0; i < n; i++){
            tank += gas[i] - cost[i];
            if(tank < 0){
                res = i + 1;
                tank = 0;
            }
        }
        return res;
    }
}