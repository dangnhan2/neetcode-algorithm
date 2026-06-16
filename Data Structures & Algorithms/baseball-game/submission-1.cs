public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> store = new Stack<int>();
        int sum=0;
        for(int i=0;i < operations.Length; i++){
            string ele = operations[i];
            if (int.TryParse(ele, out int num)) {
               store.Push(num);
            }

            if(operations[i] == "C"){
                store.Pop();
            }

            if(operations[i] == "D"){
                store.Push(store.Peek() *2);
            }
            if(operations[i] == "+"){
                int top = store.Pop();
                int newTop = store.Peek() + top;
                store.Push(top);
                store.Push(newTop);
            }
        }

        while(store.Count > 0){
            sum += store.Pop();
        }

        return sum;
    }
}