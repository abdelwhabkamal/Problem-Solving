public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int n1 = word1.Length, n2 = word2.Length;
        char[] res = new char[n1 + n2];
        int i = 0, j = 0, k = 0;

        while (i < n1 || j < n2) {
            if (i < n1) res[k++] = word1[i++];
            if (j < n2) res[k++] = word2[j++];
        }

        return new string(res);
    }
}
