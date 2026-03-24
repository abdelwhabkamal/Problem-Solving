public class Solution {
    public void MoveZeroes(int[] nums) {
        int c=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=0){
                nums[c]=nums[i];
                c++;
            }
        }
        for(int i=c;i<nums.Length;i++){
            nums[i]=0;
        }
    }
}