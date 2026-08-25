public class Solution {
    public int MissingMultiple(int[] nums, int k) {
        int[] count = new int[101];
        foreach(int num in nums)count[num]++;
        int res = k;
        while(count[res] > 0){
            res += k;
            if(res > 100) break;
        }
        return res;
    }
}