public class Solution {
    public void ReverseString(char[] s) {
       Stack<char> store = new Stack<char>();

       for(int i= 0; i < s.Length ;i++){
        store.Push(s[i]);
       }

       for(int j=0 ; j < s.Length; j++){
        s[j] = store.Pop();
       }
    }
}