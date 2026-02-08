using System;

public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int n = nums.Length;

        // Step 1: Transform the array to contain only positive integers
        for (int i = 0; i < n; i++) {
            // We ignore non-positive integers and numbers greater than n
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i]) {
                Swap(nums, i, nums[i] - 1);
            }
        }

        // Step 2: Find the first missing positive integer
        for (int i = 0; i < n; i++) {
            if (nums[i] != i + 1) {
                return i + 1;
            }
        }

        // If all positive integers from 1 to n are present, return n+1
        return n + 1;
    }

    // Helper function to swap values in the array
    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
