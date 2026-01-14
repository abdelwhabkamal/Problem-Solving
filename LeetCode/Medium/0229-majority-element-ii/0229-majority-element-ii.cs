public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        IList<int> ans= new List<int>();
        double appear=nums.Length/3;
        Dictionary<int,int> frq=new();
        foreach(int n in nums){
            if(!frq.ContainsKey(n))frq[n]=0;
            frq[n]++;
        }
        foreach (var kvp in frq){
            if(kvp.Value>appear) ans.Add(kvp.Key);
        }
        return ans;
    }
}