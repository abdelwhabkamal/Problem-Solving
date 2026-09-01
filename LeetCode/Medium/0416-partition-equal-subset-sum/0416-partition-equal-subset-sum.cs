public class Solution {
    public bool CanPartition(int[] nums) {
        int target = 0;
        foreach(int num in nums) target += num;
        if(target %2 != 0) return false;
        target /= 2;
        HashSet<int> set = new();
        set.Add(nums[nums.Length - 1]);
        for(int i = nums.Length - 2; i >= 0; i--){
            HashSet<int> newSet = new();
            foreach(int s in set){
                if(nums[i] + s == target || s == target) return true;
                newSet.Add(nums[i] + s);
                newSet.Add(s);
            }
            set = newSet;
        }
        return false;
    }
}