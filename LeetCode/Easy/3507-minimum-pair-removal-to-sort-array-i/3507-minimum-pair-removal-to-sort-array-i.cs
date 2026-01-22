public class Solution {
    public int MinimumPairRemoval(int[] nums) {
        int operations = 0;
        var list = new List<int>(nums);

        while (!IsSorted(list)) {
            int idx = MinPairIndex(list);
            list[idx] = list[idx] + list[idx + 1];
            list.RemoveAt(idx + 1);
            operations++;
        }

        return operations;
    }

    private int MinPairIndex(List<int> nums) {
        int minSum = nums[0] + nums[1];
        int index = 0;

        for (int i = 1; i < nums.Count - 1; i++) {
            int sum = nums[i] + nums[i + 1];
            if (sum < minSum) {
                minSum = sum;
                index = i;
            }
        }
        return index;
    }

    private bool IsSorted(List<int> nums) {
        for (int i = 1; i < nums.Count; i++) {
            if (nums[i] < nums[i - 1])
                return false;
        }
        return true;
    }
}
