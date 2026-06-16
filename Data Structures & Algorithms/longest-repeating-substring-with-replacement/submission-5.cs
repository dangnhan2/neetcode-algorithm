public class Solution {
    public int CharacterReplacement(string s, int k) {
        int res = 0;
        
        for(int r = 0; r < s.Length; r++){
            Dictionary<char, int> d = new Dictionary<char, int>();
            int maxf = 0;

            for(int l = r; l < s.Length; l++){
              if(!d.ContainsKey(s[l])){
                d[s[l]] = 0;
              }

              d[s[l]]++;
              maxf = Math.Max(maxf, d[s[l]]);

              if(((l - r + 1) - maxf) <= k){
                  res = Math.Max(res, l - r + 1);
              }
            }
        }

        return res;
    }
}
