public class MyStack {
    Queue<int> queue = new();
    public MyStack() {
        queue = new Queue<int>();
    }
    
    public void Push(int x) {
        queue.Enqueue(x);
        int n = queue.Count - 1;
        while(n > 0){
            queue.Enqueue(queue.Dequeue());
            n--;
        }
    }
    
    public int Pop() => queue.Dequeue();
    
    public int Top() => queue.Peek();
    
    public bool Empty() => (queue.Count == 0) ? true : false;
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */