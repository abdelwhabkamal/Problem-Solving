public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        IList<int> ans = new List<int>();
        if (s.Length < p.Length) return ans;

        int[] pCount = new int[26];
        int[] sCount = new int[26];

        foreach (char c in p) {
            pCount[c - 'a']++;
        }

        int n = p.Length;

        for (int i = 0; i < n; i++) {
            sCount[s[i] - 'a']++;
        }

        if (pCount.SequenceEqual(sCount)) ans.Add(0);

        for (int i = n; i < s.Length; i++) {
            sCount[s[i] - 'a']++;             
            sCount[s[i - n] - 'a']--;          
            if (pCount.SequenceEqual(sCount)) {
                ans.Add(i - n + 1);
            }
        }

        return ans;
    }
}
