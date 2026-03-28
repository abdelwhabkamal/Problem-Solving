public class Solution {
    public int[] SortedSquares(int[] nums) {
        int n = nums.Length;
        int[] ans = new int[n];
        int left = 0, right = n - 1;
        int pos = n - 1;

        while (left <= right) {
            int leftSq = nums[left] * nums[left];
            int rightSq = nums[right] * nums[right];
            if (leftSq > rightSq) {
                ans[pos--] = leftSq;
                left++;
            } else {
                ans[pos--] = rightSq;
                right--;
            }
        }
        return ans;
    }
}
