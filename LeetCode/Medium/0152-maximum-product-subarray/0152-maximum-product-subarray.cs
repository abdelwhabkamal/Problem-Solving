public class Solution {
    public int MaxProduct(int[] nums) {
        int res = nums[0];
        int min = 1;
        int max = 1;
        foreach(int num in nums){
            int tmp = num * min;
            min = Math.Min(Math.Min(num * max , num * min) , num);
            max = Math.Max(Math.Max(num * max , tmp) , num);
            res = Math.Max(res,max);
        }
        return res;
    }
}