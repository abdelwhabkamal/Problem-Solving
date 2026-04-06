public class MyQueue {
    List<int> queue=new();
    
    public MyQueue() {
        queue= new List<int>();    
    }

    public void Push(int x) {
        queue.Add(x);    
    }
    
    public int Pop() {
        int pop =queue[0];
        queue.RemoveAt(0);
        return pop;
    }
    
    public int Peek() {
        return queue[0];
    }
    
    public bool Empty() {
        if(queue.Count>0) return false;
        return true;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */