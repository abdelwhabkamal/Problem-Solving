public class Solution {
    public IList<int> FindMissingElements(int[] nums) {
        int min = 101;
        int max = 0;
        foreach(int num in nums){
            min = Math.Min(min , num);
            max = Math.Max(max , num);
        }
        HashSet<int> res = new HashSet<int>(Enumerable.Range(min, max - min + 1));   
        foreach(int num in nums) res.Remove(num);
        return res.ToList();   
    }
}