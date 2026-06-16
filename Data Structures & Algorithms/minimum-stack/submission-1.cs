public class MinStack {
    public Stack<int> store;
    public Stack<int> min;
    public MinStack() {
        store = new Stack<int>();
        min= new Stack<int>();
    }
    
    public void Push(int val) {
           store.Push(val);
        if(min.Count == 0 || min.Peek() >= val){
            min.Push(val);
        
    }
    }
    
    public void Pop() {
        int i = store.Pop();
        if(min.Peek() == i){
            min.Pop();
        }
    }
    
    public int Top() {
        return store.Peek();
    }
    
    public int GetMin() {
       return min.Peek();
    }

}
