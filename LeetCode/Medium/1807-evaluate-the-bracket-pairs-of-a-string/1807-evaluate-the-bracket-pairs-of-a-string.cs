public class Solution {
    public string Evaluate(string s, IList<IList<string>> knowledge) {
        Dictionary<string , string> dict = new();
        for(int i = 0; i < knowledge.Count; i++){
            dict[knowledge[i][0]] = knowledge[i][1];
        }
        StringBuilder res = new();
        int indx = 0;
        while(indx < s.Length){
            if(s[indx] != '(') res.Append(s[indx]);
            else{
                int j = indx + 1;
                while (s[j] != ')') {
                    j++;
                }
                string sub = s.Substring(indx + 1, j - indx - 1);
                if(dict.ContainsKey(sub)) res.Append(dict[sub]);
                else res.Append('?');
                indx = j;
            }
            indx++;
        }
        return res.ToString();
    }
}