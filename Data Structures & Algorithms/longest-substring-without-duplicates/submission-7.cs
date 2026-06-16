public class Solution {
    public int LengthOfLongestSubstring(string s) {
         int count = 0;

         for(int i = 0; i < s.Length; i++){
          HashSet<char> store = new HashSet<char>();
          for(int j = i; j < s.Length; j++){
             if (!store.Contains(s[j])){
              store.Add(s[j]);
             }else{
              break;
             }  
          }
          count = Math.Max(count, store.Count());
         }

         return count;
    }
}
