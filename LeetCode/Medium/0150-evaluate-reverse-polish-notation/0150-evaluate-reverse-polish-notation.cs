public class Solution {
    private int StrToInt(string token)
    {
        int value = 0;
        int multiplier = 1;
        for (int i = 0; i < token.Length; i++)
        {
            if (token[i] == '+' || token[i] == '-')
            {
                multiplier = token[i] == '-' ? -1 : 1;
            }
            else
            {
                value = value*10 + (token[i] - '0');
            }
        }

        return value * multiplier;
    }
    public int EvalRPN(string[] tokens) {
        Stack<int> stack= new();
        int val1=0;
        int val2=0;
        foreach(string t in tokens){
            if(t != "+" && t != "-" && t != "*" && t != "/"){
                stack.Push(StrToInt(t));
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