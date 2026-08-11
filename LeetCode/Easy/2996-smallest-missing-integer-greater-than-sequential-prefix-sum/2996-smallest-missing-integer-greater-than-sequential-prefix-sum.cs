public class Solution {
    public int MissingInteger(int[] nums) {
        int[] count = new int[51];
        foreach(int num in nums) count[num]++;
        int sum = nums[0];

        for(int i = 1; i < nums.Length; i++){
            if(nums[i] == nums[i-1] + 1) sum += nums[i];
            else break;
        }

        while (sum < 51 && count[sum] > 0) sum++;
        return sum;
    }
}