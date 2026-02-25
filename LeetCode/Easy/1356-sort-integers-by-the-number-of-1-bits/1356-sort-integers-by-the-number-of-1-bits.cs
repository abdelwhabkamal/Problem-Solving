public class Solution {
    public int[] SortByBits(int[] arr) {
        Array.Sort(arr, (a,b) =>{
            int b1 = int.PopCount(a);
            int b2 = int.PopCount(b);
            
            return b1 == b2 ? a - b : b1 - b2;
        });

        return arr;
    }
}