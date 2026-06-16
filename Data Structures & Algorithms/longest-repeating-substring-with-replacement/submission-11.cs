public class Solution {
    public int CharacterReplacement(string s, int k) {
        int maxLength = 0;
        for(int r =0; r < s.Length; r++){
           Dictionary<char, int> store = new Dictionary<char, int>();
           int maxf = 0;
           for(int l = r; l < s.Length; l++){
              if(!store.ContainsKey(s[l])){
                store[s[l]] = 1;
              }else{
                store[s[l]]++;
              }

              maxf = Math.Max(maxf, store[s[l]]);

              if ((l- r + 1 - maxf) <= k){
                maxLength = Math.Max(maxLength, l - r + 1);
              }
           }
        }

        return maxLength;
    }
}
