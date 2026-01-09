public class Solution {
    public int[] SortArray(int[] nums) {
        List<int> cp= new(nums);
        List<int> result= new();
        while(cp.Count != 0 ){
            int min= cp.Min();
            result.Add(min);
            cp.Remove(min);
        }
        return result.ToArray();
    }
}