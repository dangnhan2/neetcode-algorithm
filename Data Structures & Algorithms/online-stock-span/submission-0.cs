public class StockSpanner {
    
    Stack<int> store = new Stack<int>();
    public StockSpanner() {
       
    }
    
    public int Next(int price) {
        int count = 0;
        store.Push(price);
        foreach(int p in store){
           if(price < p){
              break;
            }
            count++;
        }      
        return count;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */