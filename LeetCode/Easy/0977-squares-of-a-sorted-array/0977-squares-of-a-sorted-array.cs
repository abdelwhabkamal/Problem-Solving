public class Solution {
    public int[] SortedSquares(int[] nums) {
        int n = nums.Length;
        int[] res = new int[n];
        int left = 0, right = n - 1;
        int pos = n - 1;

        while (left <= right) {
            int lsq = nums[left] * nums[left];
            int rsq = nums[right] * nums[right];
            if (lsq > rsq) {
                res[pos] = lsq;
                left++;
            } else {
                res[pos] = rsq;
                right--;
            }
            pos--;
        }

        return res;
    }
}
