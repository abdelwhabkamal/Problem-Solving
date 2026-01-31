public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        char ans = letters[0];
        foreach (char l in letters){
            if(l>target){
                ans =l;
                break;
            }
        }
        return ans;
    }
}