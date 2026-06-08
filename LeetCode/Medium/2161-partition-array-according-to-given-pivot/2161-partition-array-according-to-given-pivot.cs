public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        int l = 0;
        int r = 0;
        int m = 0;
        int n = nums.Length;
        
        for(int i = 0; i < n; i++){
            if(nums[i] < pivot) m++;
            else if(nums[i] == pivot) r++;
        }

        r += m;
        int[] res = new int[n];
        for(int i = 0; i < n; i++){
            if(nums[i] < pivot) {
                res[l] = nums[i];
                l++;
            }
            else if( nums[i] == pivot){
                res[m] = nums[i];
                m++;
            }
            else{
                res[r] = nums[i];
                r++;
            }
        }
        return res;
    }
}