public class Solution {
    public int LengthOfLongestSubstring(string s) {
       int maxLength = 0;
       for(int i = 0; i < s.Length; i++){
         HashSet<object> store = new HashSet<object>();
         for(int j = i; j < s.Length; j++){
            if(!store.Contains(s[j])){
               store.Add(s[j]);
            }else{              
               break;
            }

            maxLength = Math.Max(maxLength, store.Count());
         }
       }

       return maxLength;
    }
}
