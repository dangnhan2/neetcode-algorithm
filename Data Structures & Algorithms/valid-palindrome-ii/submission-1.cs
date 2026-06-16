public class Solution {
    public bool ValidPalindrome(string s) {     
       int first = 0;
       int end = s.Length - 1;
       while(first < end){
        if(s[first] != s[end]){
            string right = s.Substring(first, end - first);
            string left = s.Substring(first + 1, end - first);

            return IsPalindrome(right) || IsPalindrome(left);
        }
        first++;
        end--;
       }

       return true;
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