public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> s1 = new Dictionary<char,int>();
        Dictionary<char, int> s2 = new Dictionary<char,int>();
        
        if (s.Length != t.Length)
          return false;

        for(int i = 0; i < s.Length; i++){
           if (!s1.ContainsKey(s[i])){
             s1[s[i]] = 0;
           }

           s1[s[i]]++;

           if (!s2.ContainsKey(t[i])){
              s2[t[i]] = 0;
           }

           s2[t[i]]++;
        }

        foreach(var kvp in s1){
            if (!s2.ContainsKey(kvp.Key) || s2[kvp.Key] != kvp.Value)
            return false;
        }

        return true;
    }
}
