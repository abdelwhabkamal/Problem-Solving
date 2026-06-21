public class Solution {
    public int MaxIceCream(int[] costs, int coins) {
        int max = 0;
        for(int i = 0; i < costs.Length; i++){
            max = Math.Max(costs[i] , max);
        }
        int[] count = new int[max + 1];
        for(int i = 0; i < costs.Length; i++){
            count[costs[i]]++;
        }
        int sum = 0;
        int res = 0; 
        for(int i = 1; i <= max; i++){
            while(count[i] > 0){
                sum += i;
                if(sum > coins) return res;
                res++;
                count[i]--;
            }
        }
        return res;
    }
}