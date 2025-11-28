public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
       IList<IList<int>> result= new List<IList<int>>(); 
       List<int> curr= new();
       void back(int i,List<int> curr,int total){
            if(total==target) {
                result.Add(new List<int>(curr));
                return;
            }
            if(total>target || i>=candidates.Length) return;
            curr.Add(candidates[i]);
            back(i,curr,candidates[i]+total);
            curr.RemoveAt(curr.Count-1);
            back(i+1,curr,total);
        }
       back(0,curr,0);
       return result;
    }
    
}