public class Solution {
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2) {
        int[] values = new int[1001];
        for(int i = 0; i < items1.Length; i++){
            values[items1[i][0]] = items1[i][1];
        }
        for(int i = 0; i < items2.Length; i++){
            values[items2[i][0]] += items2[i][1];
        }
        IList<IList<int>> res = new List<IList<int>>();
        for(int i = 1; i <= 1000; i++){
            if(values[i] > 0) res.Add([i , values[i]]);
        }
        return res;
    }
}