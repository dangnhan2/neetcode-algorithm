public class Solution {
    public int CharacterReplacement(string s, int k) {
       int count = 0;
       for(int i = 0; i < s.Length; i++){
        int maxf = 0;
        Dictionary<char,int> store = new Dictionary<char,int>();
        for(int j = i; j < s.Length; j++){
           if (!store.ContainsKey(s[j])){
            store[s[j]] = 1;
           }else{
            store[s[j]]++;
           }

           maxf = Math.Max(maxf, store[s[j]]);

           if((j - i + 1 - maxf) <= k){
            count = Math.Max(count, j - i + 1);
           }
        }

       }

       return count;
    }
}