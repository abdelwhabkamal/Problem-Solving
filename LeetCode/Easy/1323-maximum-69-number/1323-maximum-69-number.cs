using System.Text.RegularExpressions;

public class Solution {
    
    public int Maximum69Number (int num) => Convert.ToInt32(ReplaceFirstChar(num.ToString(),'6','9'));

    string ReplaceFirstChar(string text, char oldChar, char newChar) {
        int index = text.IndexOf(oldChar);
        if (index == -1)
            return text;

        return text.Remove(index, 1)
                .Insert(index, newChar.ToString());
    }


}