public class Solution {
    public IList<int> FindMissingElements(int[] nums) {
        int min = 101;
        int max = 0;
        foreach(int num in nums){
            min = Math.Min(min , num);
            max = Math.Max(max , num);
        }
        IList<int> res = Enumerable.Range(min, max - min + 1).ToList();   
        foreach(int num in nums) res.Remove(num);
        return res;   
    }
}