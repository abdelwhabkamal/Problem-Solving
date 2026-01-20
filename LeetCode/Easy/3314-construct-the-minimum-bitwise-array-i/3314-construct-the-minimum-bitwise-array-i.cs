public class Solution {
    public int[] MinBitwiseArray(IList<int> nums) {
        int[] result = new int[nums.Count];

        for (int i = 0; i < nums.Count; i++) {
            int candidate = -1;
            for (int j = 1; j < nums[i]; j++) {
                if ((j | (j + 1)) == nums[i]) {
                    candidate = j;
                    break;
                }
            }
            result[i] = candidate;
        }
        return result;
    }
}