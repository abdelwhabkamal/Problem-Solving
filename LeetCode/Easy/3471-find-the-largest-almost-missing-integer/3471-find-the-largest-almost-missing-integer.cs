public class Solution {
    public int LargestInteger(int[] nums, int k) {
        int n = nums.Length;
        if(n == k){
            int max = -1;
            foreach(int num in nums) max = Math.Max(max , num);
            return max;
        } 
        if(k == 1){
           int[] count= new int[51];
           for(int i = 0; i < n; i++) count[nums[i]]++;
           int max = -1;
           for(int i = 0; i < 51; i++){
                if(count[i] == 1) max = Math.Max(max , i);
            }
            return max;
        }
        int f = nums[0]; 
        int l = nums[n-1];
        if(f == l) return -1;
        for(int i = 1; i < n - 1; i++){
            if(nums[i] == f) f = -1;
            else if(nums[i] == l) l = -1;
        }
        return Math.Max(f,l);
    }
}