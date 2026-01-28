public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack= new();
        int val1=0;
        int val2=0;
        foreach(string t in tokens){
            if(t != "+" && t != "-" && t != "*" && t != "/"){
                stack.Push(int.Parse(t));
            }else{
                val1=stack.Pop();
                val2=stack.Pop();
                switch(t){
                    case "+": stack.Push(val1+val2); break;
                    case "-": stack.Push(val2-val1); break;
                    case "*": stack.Push(val1*val2); break;
                    case "/": stack.Push(val2/val1); break;
                }
                    
            }
        }
        return stack.Pop();
    }
}