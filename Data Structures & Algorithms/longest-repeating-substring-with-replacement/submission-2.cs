public class Solution {
    public int CharacterReplacement(string s, int k) {
        int maxLength = 0;
        Dictionary<char, int> count = new Dictionary<char, int>();
        int l = 0;
        int maxf = 0;

        for(int r = 0; r < s.Length; r++){
            if (count.ContainsKey(s[r])){
                count[s[r]]++;
            }else{
                count[s[r]] = 1;
            }

            maxf = Math.Max(count[s[r]], maxf);

            while((r - l + 1) - maxf > k){
                count[s[l]]--;
                l++;
            }

            maxLength = Math.Max(r - l + 1, maxLength);
        }

        return maxLength;
    }
}
