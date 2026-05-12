public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char,char> map = new();
        for(int i = 0; i< s.Length; i++){
            if(!map.ContainsKey(s[i]) && !map.ContainsValue(t[i])) map[s[i]] = t[i];
            else{
                if(!map.ContainsKey(s[i]) || map[s[i]] != t[i]) return false;
            }
        }
        return true;
    }
}
