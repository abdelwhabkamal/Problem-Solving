public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0;
        int n = numbers.Length;
        int r = n - 1;
        while(l <= r){
            int sum = numbers[l] + numbers[r];
            if(sum == target) return [l+1 , r+1];
            else if(sum < target) l++;
            else r--;
        }
        return [-1,-1];
    }
}