public class Solution {
    private int FastParse(string s) {
        bool isNegetive = s[0] == '-';
        int i = isNegetive ? 1 : 0;
        int result = 0;
        for (; i < s.Length; i++)
            result = result * 10 + (s[i] - '0');
        return isNegetive ? -result : result;
    }
    public int EvalRPN(string[] tokens) {
        int val1=0;
        int val2=0;
        Stack<int> stack = new Stack<int>();
        foreach(string s in tokens){
            if(s!="*" && s!="/" && s!="+" && s!="-"){
                stack.Push(FastParse(s));
            }else{
                val1=stack.Pop();         
                val2=stack.Pop();
                switch(s){
                    case "+":
                        stack.Push(val2+val1);
                        break;
                    case "-":
                        stack.Push(val2-val1);
                        break;
                    case "*":
                        stack.Push(val2*val1);
                        break;
                    case "/": 
                        stack.Push(val2/val1);
                        break;
                }
            }
        }
        return stack.Pop();
    }
}
