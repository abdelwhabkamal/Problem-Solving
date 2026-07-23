public class StockSpanner {
    List<int> stock;
    public StockSpanner() {
        stock = new List<int>();
    }
    
    public int Next(int price) {
        stock.Add(price);
        int res = 0;
        Stack<int> stack = new(stock);
        while(stack.Count > 0){
            if(stack.Pop() <= price ) res ++;
            else return res;
        }
        return res;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */