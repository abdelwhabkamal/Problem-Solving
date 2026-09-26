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
                indx++;
                StringBuilder sub = new();
                while(s[indx] != ')'){
                    sub.Append(s[indx]);
                    indx++;
                }
                if(dict.ContainsKey(sub.ToString())) res.Append(dict[sub.ToString()]);
                else res.Append('?');
            }
            indx++;
        }
        return res.ToString();
    }
}