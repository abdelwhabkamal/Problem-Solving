public class Solution {
    public bool HasAllCodes(string s, int k) {
        int target = (1<<k);
        int count = 0;
        Dictionary<string,bool> map = new();
        for(int i = 0; i < s.Length-k+1; i++)
        {
            string str = s.Substring(i,k);
            map.TryAdd(str, true);   
        }
        return target == map.Count;
    }
}