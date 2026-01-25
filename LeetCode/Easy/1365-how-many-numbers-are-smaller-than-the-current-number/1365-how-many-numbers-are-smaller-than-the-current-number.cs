public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] ans = new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
            int c=0;
            for(int j=0;j<nums.Length;j++){
                if(nums[i]>nums[j] && i != j )c++;
            }
            ans[i]=c;
        }
        return ans;
    }
}