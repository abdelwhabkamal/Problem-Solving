public class StockSpanner {
    private Stack<(int price, int cnt)> st;

    public StockSpanner()
    {
        st = new Stack<(int, int)>();
    }
    
    public int Next(int price) {
        int cnt = 1;
        while(st.Count > 0 && st.Peek().price <= price){
            cnt += st.Peek().cnt;
            st.Pop();
        }
        st.Push((price , cnt));
        return cnt;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */