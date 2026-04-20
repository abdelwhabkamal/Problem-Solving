public class Solution {
    public int[] MinOperations(string boxes) {
        int n = boxes.Length;
        int[] res = new int[n];
        List<int> ones = new();
        for(int i = 0; i < n; i++){
            if(boxes[i] == '1') ones.Add(i);
        }
        for(int i = 0; i < n; i++){
            for(int j = 0; j < ones.Count; j++){
                res[i] += Math.Abs(i - ones[j]);
            }
        }
        return res;
    }
}