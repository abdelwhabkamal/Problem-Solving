public class Solution {
    public int MajorityElement(int[] nums) {
        int c = 0;
        int res = 0;
        foreach(int num in nums){
            if(c == 0) res = num;
            if(res == num) c++;
            else c--; 
        }
        return res;
    }
}