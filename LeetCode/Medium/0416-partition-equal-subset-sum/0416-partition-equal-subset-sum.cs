public class Solution {
    public bool CanPartition(int[] nums) {
        int sum = nums.Sum();
        if (sum % 2 != 0) return false;
        int target = sum / 2;

        HashSet<int> set = new();
        set.Add(0); 

        foreach (int num in nums) {
            HashSet<int> newSet = new(set);
            foreach (int s in set) {
                int newSum = s + num;
                if (newSum == target) return true;
                newSet.Add(newSum);
            }
            set = newSet;
        }

        return false;
    }
}
