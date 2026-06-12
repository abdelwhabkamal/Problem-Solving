class Solution {
    public int SemiOrderedPermutation(int[] nums) {
        int n = nums.Length;
        int min = 0;

        int max = 0;

        for (int i = 0; i < n; i++) {

            int num = nums[i];

            if (num == 1) {
                min = i;
            }

            if (nums[i] == n) {
                max = i;
            }
        }

        int swaps = min + (n - 1 - max);

        return min > max ? --swaps : swaps;
    }
}