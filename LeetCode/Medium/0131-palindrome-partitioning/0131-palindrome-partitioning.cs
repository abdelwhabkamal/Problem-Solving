public class Solution {
    private IList<IList<string>> res = new List<IList<string>>();
    private List<string> part = new List<string>();

    public IList<IList<string>> Partition(string s) {
        dfs(0, 0, s);
        return res;
    }

    private void dfs(int j, int i, string s) {
        if (i >= s.Length) {
            if (i == j) {
                res.Add(new List<string>(part));
            }
            return;
        }

        if (isPali(s, j, i)) {
            part.Add(s.Substring(j, i - j + 1));
            dfs(i + 1, i + 1, s);
            part.RemoveAt(part.Count - 1);
        }

        dfs(j, i + 1, s);
    }

    private bool isPali(string s, int l, int r) {
        while (l < r) {
            if (s[l] != s[r]) {
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}