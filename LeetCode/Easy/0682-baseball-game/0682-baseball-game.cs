public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> stack = new();

        foreach (string o in operations) {
            switch (o) {
                case "C":
                    stack.Pop();
                    break;

                case "D":
                    stack.Push(2 * stack.Peek());
                    break;

                case "+":
                    int top = stack.Pop();
                    int newTop = top + stack.Peek();
                    stack.Push(top);       
                    stack.Push(newTop);    
                    break;

                default:
                    stack.Push(int.Parse(o));
                    break;
            }
        }

        return stack.Sum();
    }
}
