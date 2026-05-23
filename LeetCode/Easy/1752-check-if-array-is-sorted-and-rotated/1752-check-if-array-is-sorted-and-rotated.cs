public class Solution {
    public bool Check(int[] nums) {
        int n = nums.Length;
        bool flag = false;
        for(int i = 0; i< n; i++){
            if(nums[i] > nums[ ( i + 1) % n]){
                if(flag) return false;
                flag = true;
            }
        }
        return true;
    }
}