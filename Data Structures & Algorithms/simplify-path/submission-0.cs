public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> stack = new Stack<string>();
        string cur = "";
        foreach(char p in path + "/"){
           if(p == '/'){
            if(cur == ".."){
                if(stack.Count > 0){
                  stack.Pop();
                }               
            }else if(cur != "" && cur != "."){
                stack.Push(cur);
            }

            cur ="";
           }else{
              cur += p.ToString();
           }         
        }

        List<string> s = new List<string>(stack);
        s.Reverse();
       
        return "/" + string.Join("/", s);
    }
}