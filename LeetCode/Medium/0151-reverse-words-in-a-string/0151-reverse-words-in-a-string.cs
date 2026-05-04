public class Solution {
    public string ReverseWords(string s) {
        string[] str = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder result = new StringBuilder();
        for(int i =str.Length-1; i>0;i--)
        {
            result.Append(str[i]);
            result.Append(' ');
        }
        result.Append(str[0]);
        return result.ToString();
    }
}