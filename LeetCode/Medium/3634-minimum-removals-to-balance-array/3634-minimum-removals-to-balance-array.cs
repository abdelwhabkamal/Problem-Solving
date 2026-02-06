public class Solution {
    public int MinRemoval(int[] nums, int k) {
        if(nums.Length <= 1){
            return 0;
        }

        Array.Sort(nums);

        int i = 0;
        var count = 0;
        for(int j = 0; j < nums.Length; j++){
           while(nums[j] > (long)k * (long)nums[i]){
                i++;
           } 

            count = Math.Max(count, j - i + 1);
        }
        

        return nums.Length - count;
    }
}