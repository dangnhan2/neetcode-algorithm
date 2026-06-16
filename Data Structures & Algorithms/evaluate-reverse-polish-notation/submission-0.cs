public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> store = new Stack<int>();
        int sum=0;
        for(int i=0; i< tokens.Length; i++){
            if(int.TryParse(tokens[i], out int number)){
                store.Push(number);
            }else if(tokens[i] == "+"){
                int top = store.Pop();
                int newTop = top + store.Pop();
                store.Push(newTop);
            }else if(tokens[i] == "*"){
                int top = store.Pop();
                int newTop = top * store.Pop();
                store.Push(newTop);
            }else if(tokens[i] == "/"){
                int top = store.Pop();
                int newTop = store.Pop() / top;
                store.Push(newTop);
            }else{
                int top = store.Pop();
                int newTop = store.Pop() - top;
                store.Push(newTop);
            }          
        }
        sum += store.Pop();
        return sum;
    }
}
