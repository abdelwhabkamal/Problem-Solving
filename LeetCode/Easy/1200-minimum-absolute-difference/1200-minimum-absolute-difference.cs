public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        int min=int.MaxValue;
        IList<IList<int>> ans= new List<IList<int>>();
        Array.Sort(arr);
        for(int i=1;i<arr.Length;i++){
            if(arr[i]-arr[i-1]<min) min= arr[i]-arr[i-1];
        }
        for(int i=1;i<arr.Length;i++){
            if(arr[i]-arr[i-1]==min) 
                ans.Add([arr[i-1],arr[i]]);
        }
        return ans;
    }
}