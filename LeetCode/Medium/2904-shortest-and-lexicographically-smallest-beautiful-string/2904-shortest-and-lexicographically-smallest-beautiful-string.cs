public class Solution {
    public string ShortestBeautifulSubstring(string s, int k) {
        int n = s.Length;
        int left = 0, count = 0;
        string res = "";
        StringBuilder window = new();

        for (int right = 0; right < n; right++) {
            window.Append(s[right]);
            if (s[right] == '1') count++;

            while (count == k) {
                string candidate = window.ToString();

                if (res == "" || candidate.Length < res.Length ||
                   (candidate.Length == res.Length && string.Compare(candidate, res) < 0)) {
                    res = candidate;
                }

                if (window[0] == '1') count--;
                window.Remove(0, 1);
                left++;
            }
        }

        return res;
    }
}
