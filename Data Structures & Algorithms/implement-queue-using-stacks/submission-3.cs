public class MyQueue {
    
    public Stack<int> stack1 = new Stack<int>();
    public Stack<int> stack2 = new Stack<int>();
    public MyQueue() {
        
    }
    
    public void Push(int x) {
         stack1.Push(x);
    }
    
    public int Pop() {
        if(stack2.Count ==0){
           while(stack1.Count > 0){
            stack2.Push(stack1.Pop());
         }
        }
        
        int val = stack2.Pop();
        return val;
    }
    
    public int Peek() {
        if(stack2.Count ==0){
           while(stack1.Count > 0){
            stack2.Push(stack1.Pop());
         }
        }

        int val = stack2.Peek();
        return val;
    }
    
    public bool Empty() {
       return stack1.Count == 0 && stack2.Count == 0;
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