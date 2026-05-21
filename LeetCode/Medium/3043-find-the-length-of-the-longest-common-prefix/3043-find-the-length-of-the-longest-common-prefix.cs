public class Solution {
    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
        HashSet<int> p = new HashSet<int>();

        foreach(int n in arr1){
            int curr = n;

            while(curr>0){
                p.Add(curr);
                curr/=10;
            }
        }

        int maxLen = 0;

        foreach(int n in arr2){
            int curr = n;

            while(curr>0){
                if(p.Contains(curr)){
                    int len = curr.ToString().Length;
                    maxLen = Math.Max(maxLen, len);
                }
                curr/=10;
            }
        }
        return maxLen;
    }
}