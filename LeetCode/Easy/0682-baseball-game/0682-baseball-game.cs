public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> stack = new();
        
        foreach (string o in operations) {
            if (int.TryParse(o, out int num)) {
                stack.Push(num);
            } 
            else if (o == "C") {
                stack.Pop();
            } 
            else if (o == "D") {
                stack.Push(2 * stack.Peek());
            } 
            else if (o == "+") {
                int top = stack.Pop();
                int newTop = top + stack.Peek();
                stack.Push(top);       
                stack.Push(newTop);    
            }
        }
        
        return stack.Sum();
    }
}
