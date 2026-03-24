public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> indx=new();
        for(int i=0;i<nums.Length;i++){
            if(indx.ContainsKey(target-nums[i])){
                return [indx[target-nums[i]],i];
            }
            indx[nums[i]]=i;
        }
        return [];
    }
}