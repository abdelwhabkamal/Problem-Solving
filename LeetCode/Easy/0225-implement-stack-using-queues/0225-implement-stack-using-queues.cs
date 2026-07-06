public class MyStack {
    Queue<int> queue = new();
    public MyStack() {
        queue = new Queue<int>();
    }
    
    public void Push(int x) {
        queue.Enqueue(x);
    }
    
    public int Pop() {
        Queue<int> newQueue = new Queue<int>();
        while (queue.Count > 1)
        {
            newQueue.Enqueue(queue.Dequeue());
        }
        int res = queue.Dequeue();
        queue = newQueue;
        return res;
    }
    
    public int Top() => queue.Last();
    
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