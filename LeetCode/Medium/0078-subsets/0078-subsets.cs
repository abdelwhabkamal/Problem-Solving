public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
       IList<IList<int>> res= new List<IList<int>>(); 
       List<int> sub=new();
       void dfs(int i){
        if(i>=nums.Length){
            res.Add(new List<int>(sub));
            return;
        }
        sub.Add(nums[i]);
        dfs(i+1);
        sub.RemoveAt(sub.Count-1);
        dfs(i+1);
       }
       dfs(0);
       return res;
    }
}