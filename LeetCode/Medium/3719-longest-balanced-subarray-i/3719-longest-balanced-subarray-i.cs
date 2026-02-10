public class Solution {
    public int LongestBalanced(int[] nums) 
    {
        int ans = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            Dictionary<int,bool> map1 = new();
            Dictionary<int,bool> map2 = new();
            for(int j = i; j < nums.Length; j++)
            {
                if(nums[j]%2 == 0)
                    map1.TryAdd(nums[j],true);
                else
                    map2.TryAdd(nums[j],true);
                if(map1.Count == map2.Count)
                    ans = Math.Max(ans, j-i+1);
            }
        }    
        return ans;
    }
}