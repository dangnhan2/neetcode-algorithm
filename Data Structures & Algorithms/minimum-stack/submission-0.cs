public class MinStack {
    public Stack<int> store;
    public MinStack() {
        store = new Stack<int>();
    }
    
    public void Push(int val) {
        store.Push(val);
    }
    
    public void Pop() {
        store.Pop();
    }
    
    public int Top() {
        var value = store.Peek();
        return value;
    }
    
    public int GetMin() {
        if(store.Count == 0) return -1;
        int min = store.Peek();
        foreach(int num in store){
            if(num < min){
                min = num;
            }
        }

        return min;
    }
}
