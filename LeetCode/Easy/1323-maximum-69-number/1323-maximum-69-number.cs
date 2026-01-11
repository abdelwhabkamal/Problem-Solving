using System.Text.RegularExpressions;

public class Solution {

    public int Maximum69Number (int num) => Convert.ToInt32(ReplaceFirst(num.ToString(),'6','9'));

    string ReplaceFirst(string text, char oldChar, char newChar) {
        int index = text.IndexOf(oldChar);
        if (index == -1)
            return text;
        text=text.Remove(index, 1);
        text=newChar+text;
        return text;
    }


}