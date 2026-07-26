public class Solution {
    public int MaximumProduct(int[] nums) {
        int f = -1000;
        int s = -1000;
        int t = -1000;
        int neg1 = 0;
        int neg2 = 0;
        foreach(int num in nums){
            if(num >= f){
                t = s;
                s = f;
                f = num;
            }
            else if(num >= s){
                t = s;
                s = num;
            }
            else if(num >= t) t = num;

            if(num <= neg1){
                neg2 = neg1;
                neg1 = num;
            }
            else if( num < neg2) neg2 = num;
        }
        return Math.Max(f * s * t , neg1 * neg2 * f);
    }
}