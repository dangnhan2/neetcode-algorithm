public class Solution {
    public int LengthOfLongestSubstring(string s) {
       int maxLength = 0;
       int l = 0;
       Dictionary<char, int> store = new Dictionary<char, int>();

       for(int i = 0; i < s.Length; i++){
         if (store.ContainsKey(s[i])){
            l = Math.Max(store[s[i]] + 1, l);
         }      
         store[s[i]] = i;
         maxLength = Math.Max(maxLength, i - l + 1);
       }

       return maxLength;
    }
}
