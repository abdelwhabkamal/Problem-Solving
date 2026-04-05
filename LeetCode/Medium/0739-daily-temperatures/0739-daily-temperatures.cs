public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n=temperatures.Length;
        int[] ans =new int[n];
        Stack<int> stack=new();
        for(int i=0;i<n;i++){
            while(stack.Count>0 && temperatures[stack.Peek()]<temperatures[i]){
                int index=stack.Pop();
                ans[index]=i-index;

            }
            stack.Push(i);
        }
        return ans;
    }
}