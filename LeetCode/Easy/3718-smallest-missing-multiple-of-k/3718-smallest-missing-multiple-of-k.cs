public class Solution {
    public int MissingMultiple(int[] nums, int k) {
        HashSet<int> set =  new(nums);
        int res = k;
        while(set.Contains(res)){
            res += k;
        }
        return res;
    }
}