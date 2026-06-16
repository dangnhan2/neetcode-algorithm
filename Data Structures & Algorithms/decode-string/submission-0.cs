public class Solution {
    public string DecodeString(string s) {

        Stack<string> store = new Stack<string>();
        for(int i=0; i<s.Length;i++){
           if(s[i] != ']'){
            store.Push(s[i].ToString());
           }else{
            string tmp = "";
            while(store.Peek() != "["){
                tmp = store.Pop() + tmp;
            }
            store.Pop(); // remove "["
            string k = "";
            while(store.Count > 0 && char.IsDigit(store.Peek()[0])){
                k = store.Pop() + k;
            }
             int repeat = int.Parse(k);

             string expanded = new StringBuilder().Insert(0, tmp, repeat).ToString();
                store.Push(expanded);
           }
        }
        
        var result = new StringBuilder();
        foreach (string part in store) {
            result.Insert(0, part);
        }
        return result.ToString();
    }
}