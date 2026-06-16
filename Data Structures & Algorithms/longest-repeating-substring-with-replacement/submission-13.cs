public class Solution {
    public int CharacterReplacement(string s, int k) {
        int res =0;
        int l = 0;
        int maxf = 0;
        Dictionary<char, int> count = new Dictionary<char, int>();

        for (int r = 0; r < s.Length; r++){
            if(!count.ContainsKey(s[r])){
                count[s[r]] = 1;
            }else{
                count[s[r]]++;
            }

            maxf = Math.Max(maxf, count[s[r]]);

            while (r - l + 1 - maxf > k){
                count[s[l]]--;
                l++;
            }
            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}