public class Solution {
    public string ProcessStr(string s) {
        string res = "";
        foreach(char c in s){
            if(char.IsLetter(c)){
                res += c;
            }
            else{
                if(res.Length > 0 && c == '*'){
                    res = res.Remove(res.Length - 1);
                }
                else if(res.Length > 0 && c == '%'){
                    char[] stringArray = res.ToCharArray();
                    Array.Reverse(stringArray);
                    res = new string(stringArray);
                }
                else if(res.Length > 0 && c == '#'){
                    res += res;
                }
            }
        }
        return res;
    }
}