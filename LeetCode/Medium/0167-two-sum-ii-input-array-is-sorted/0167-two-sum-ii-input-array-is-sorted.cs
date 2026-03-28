public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l=0;
        int r=numbers.Length-1;
        for(int i=0;i<numbers.Length;i++){
            if(numbers[l]+numbers[r]==target)return [l+1,r+1];
            else if(numbers[l]+numbers[r]>target) r--;
            else if(numbers[l]+numbers[r]<target) l++;
        }
        return [-1,-1];
    }
}