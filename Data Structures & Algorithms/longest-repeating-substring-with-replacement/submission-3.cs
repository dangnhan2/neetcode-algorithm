public class Solution {
    public int CharacterReplacement(string s, int k) {
        int maxLength = 0;

        for(int r = 0; r < s.Length; r++){
            Dictionary<char, int> count = new Dictionary<char,int>();
            int maxf = 0;
            for (int j = r ; j < s.Length; j++){
                if(count.ContainsKey(s[j])){
                    count[s[j]]++;
                }else{
                    count[s[j]] = 1;
                }

                maxf = Math.Max(count[s[j]], maxf);

                if ((j - r + 1) - maxf <= k){
                    maxLength = Math.Max(j - r + 1, maxLength);
                }
            }
        }

        return maxLength;
    }
}
