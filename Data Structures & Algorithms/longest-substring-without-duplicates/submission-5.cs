public class Solution {
    public int LengthOfLongestSubstring(string s) {
         int i = 0;
         int maxLength = 0;
         HashSet<char> store = new HashSet<char>();
         for(int j =0; j < s.Length; j++){
             while(store.Contains(s[j])){
                store.Remove(s[i]);
                i++;
             }
             store.Add(s[j]);
             maxLength = Math.Max(maxLength, (j-i +1));              
         }

         return maxLength;
    }
}
