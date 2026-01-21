public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max=0;
        int curr=0;
        foreach(int num in nums){
            if (num ==1)curr++;
            else curr=0;
            max=Math.Max(max,curr);
        }
        return max;
    }
}