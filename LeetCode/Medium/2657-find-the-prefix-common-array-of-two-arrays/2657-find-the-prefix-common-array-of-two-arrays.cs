public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        int n = A.Length;
        int[] ans = new int[n];

        HashSet<int> curA = new();
        HashSet<int> curB= new();

        for(int i = 0; i < n; i++ ){
            curA.Add(A[i]);
            curB.Add(B[i]);
            var res = curA.Intersect(curB);
            ans[i] = res.Count();
        }
        
        return ans;
    }
}
