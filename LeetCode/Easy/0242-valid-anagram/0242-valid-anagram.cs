public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] arr = new int[26];
        foreach(char c in s){
            arr[c-'a']+=1;
        }
        foreach(char c in t){
            arr[c-'a']-=1;
        }
        foreach(int a in arr){
            if(a!=0) return false;
        }
        return true;
    }
}