public class Solution {
    public bool ValidPalindrome(string s) {     
       if (IsPalindrome(s)){
        return true;
       }
       
       for(int i=0; i< s.Length; i++){
        string newS = s.Substring(0, i) + s.Substring(i + 1);

        if(IsPalindrome(newS)) return true;
       }
       
       

       return false;
    }

    public bool IsPalindrome(string s){
        int first = 0;
        int end = s.Length - 1;
        while(first < end){
            if(s[first] != s[end]){
                return false;
            }
           first++;
           end--;
        }
            return true;
    }
}