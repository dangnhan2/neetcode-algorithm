public class Solution {
    public int LengthOfLongestSubstring(string s) {
       int maxLength = 0;
       int l = 0;
       HashSet<char> store = new HashSet<char>();
       for(int i = 0; i < s.Length; i++){
         while(store.Contains(s[i])){
            store.Remove(s[l]);
            l++;
         }
         store.Add(s[i]);
         maxLength = Math.Max(maxLength, i - l + 1);
       }

       return maxLength;
    }
}
