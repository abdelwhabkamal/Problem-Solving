public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack= new();
        int val1=0;
        int val2=0;
        for(int i=0; i<tokens.Length; i++){
            if(tokens[i] != "+" && tokens[i] != "*" && tokens[i] != "-" && tokens[i] != "/" ){
                stack.Push(int.Parse(tokens[i]));
            }
            else{
                val2=stack.Pop();
                val1=stack.Pop();
                if(tokens[i]=="*")  stack.Push(val1*val2);
                else if(tokens[i]=="/")  stack.Push(val1/val2);
                else if(tokens[i]=="-")  stack.Push(val1-val2);
                else stack.Push(val1+val2);
            }
        }
        return stack.Pop();
    }
}