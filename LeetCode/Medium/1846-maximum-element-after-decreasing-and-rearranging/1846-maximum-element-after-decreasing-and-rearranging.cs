public class Solution {
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr) {
        Array.Sort(arr);
        int res = 1;
        for(int i = 1; i < arr.Length; i++){
            if(arr[i] > res) res++;
        }
        return res;
    }
}