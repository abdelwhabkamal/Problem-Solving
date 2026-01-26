public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        int min=int.MaxValue;
        IList<IList<int>> ans= new List<IList<int>>();
        Array.Sort(arr);
        for(int i=0;i<arr.Length-1;i++){
            if(Math.Abs(arr[i]-arr[i+1])<min) min= Math.Abs(arr[i]-arr[i+1]);
        }
        for(int i=0;i<arr.Length-1;i++){
            if(Math.Abs(arr[i]-arr[i+1])==min) 
                ans.Add([arr[i],arr[i+1]]);
        }
        return ans;
    }
}