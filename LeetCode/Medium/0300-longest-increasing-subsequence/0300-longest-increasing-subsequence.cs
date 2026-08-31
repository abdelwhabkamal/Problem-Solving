public class Solution {
    public int LengthOfLIS(int[] nums) {
        List<int> sub = new();
        sub.Add(nums[0]);
        
        for (int i = 1; i < nums.Length; i++) {
            int num = nums[i];
            if (num > sub[sub.Count-1]) {
                sub.Add(num);
            } else {
                int j = sub.BinarySearch(num);
                if(j < 0) j = Math.Abs(j) - 1;
                sub[j] = num;
            }
        }
        return sub.Count;
    }
    
}