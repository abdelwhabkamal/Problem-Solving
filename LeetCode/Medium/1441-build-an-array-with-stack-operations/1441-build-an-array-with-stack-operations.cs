public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        IList<string> ans = new List<string>(); 
        int c=0;
        for(int i=1;i<=target[target.Length-1];i++){
            ans.Add("Push");
            if(i!=target[c])ans.Add("Pop");
            else c++;
        }
        return ans;
    }
}