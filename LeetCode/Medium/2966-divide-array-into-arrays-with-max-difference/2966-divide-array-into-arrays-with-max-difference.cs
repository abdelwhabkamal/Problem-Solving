public class Solution {
    public int[][] DivideArray(int[] nums, int k) {
        Array.Sort(nums);
        int[][] res = new int[nums.Length / 3][];
        int c = 0;
        for(int i = 2; i < nums.Length; i+=3){
            if(nums[i] - nums [i - 2] > k) return [];
            res[c] = new int[] {nums[i - 2] , nums[i-1] , nums[i]};
            c++;
        }
        return res;
    }
}