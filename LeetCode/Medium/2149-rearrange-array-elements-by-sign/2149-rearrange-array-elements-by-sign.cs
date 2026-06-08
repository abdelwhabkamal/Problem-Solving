public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int p = 0;
        int n = 1;
        int[] res = new int[nums.Length];
        foreach( int num in nums){
            if(num > 0){
                res[p] = num;
                p += 2;
            }
            else{
                res[n] = num;
                n +=2;
            }
        }
        return res;
    }
}