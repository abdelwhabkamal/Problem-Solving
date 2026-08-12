public class Solution {
    public int MaxSubarrayLength(int[] nums, int k) {
        int longest = 0;
        Dictionary<int , int> freq = new();
        int l = 0;
        for(int i = 0; i < nums.Length; i++){
            if(!freq.ContainsKey(nums[i])) freq[nums[i]] = 0;
            freq[nums[i]]++;
            while(freq[nums[i]] > k){
                freq[nums[l]]--;
                l++;
            }
            longest = Math.Max(longest , i - l + 1);
        }
        return longest;
    }
}