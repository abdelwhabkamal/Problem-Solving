public class Solution {
    public int PivotIndex(int[] nums) 
    {
        if (nums == null || nums.Length == 0) return -1;

        int total =  0;
        foreach(int n in nums)
            total = total + n;
        int leftSum =0;
        for(int i=0; i< nums.Length; i++)
        {
            if(leftSum == total - nums[i] - leftSum)
                return i;
            leftSum = leftSum + nums[i];
        }
        return -1;
    }
}