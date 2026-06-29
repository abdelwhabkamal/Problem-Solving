public class Solution {
    public long WaysToBuyPensPencils(int total, int cost1, int cost2) {
        long res = 0;
        int low = Math.Min(cost1, cost2), high = Math.Max(cost1, cost2), size = total /high;
        for(int i = 0; i <= size; i++)
        {
            res += (total-i*high)/low +1;
        }

        return res;
    }
}