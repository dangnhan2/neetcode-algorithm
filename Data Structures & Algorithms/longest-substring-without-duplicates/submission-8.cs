public class Solution {
    public int LengthOfLongestSubstring(string s) {
       int count = 0;
       int i =0;
       int j =0;
       HashSet<char> store = new HashSet<char>();

       while(i < s.Length){
         while(store.Contains(s[i])){
          store.Remove(s[j]);
          j++;
         }

         if (!store.Contains(s[i])){
          store.Add(s[i]);
         }

         count = Math.Max(count, store.Count());
         i++;
       }
       return count;
    }
}
