public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int n = gas.Length;
        int tank = 0;
        int total_gas = 0;
        int res = 0;
        for(int i = 0; i < n; i++){
            total_gas += gas[i] - cost[i];
            tank += gas[i] - cost[i];
            if(tank < 0){
                res = i + 1;
                tank = 0;
            }
        }
        return total_gas >= 0 ? res : -1;
    }
}