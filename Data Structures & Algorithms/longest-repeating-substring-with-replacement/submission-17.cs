public class Solution {
    public int CharacterReplacement(string s, int k) {
        int count = 0;
        int mostf = 0;
        int l = 0;
        Dictionary<char, int> store = new Dictionary<char, int>();
        for (int r = 0; r < s.Length; r++) {
            if (!store.ContainsKey(s[r])) {
                store[s[r]] = 1;
            } else {
                store[s[r]]++;
            }

            mostf = Math.Max(store[s[r]], mostf);
            
            if(r - l + 1 - mostf > k){
                store[s[l]]--;
                l++;
            }
            count = Math.Max(r - l + 1, count);
        }
        return count;
    }
}
