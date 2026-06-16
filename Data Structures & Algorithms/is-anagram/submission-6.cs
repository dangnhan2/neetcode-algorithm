public class Solution {
    public bool IsAnagram(string s, string t) {
     if (s.Length != t.Length)
      return false;

     Dictionary<char,int> s1 = new Dictionary<char,int>();
     Dictionary<char,int> s2 = new Dictionary<char,int>();
     
     for(int i=0; i < s.Length; i++){
      if(!s1.ContainsKey(s[i])){
        s1[s[i]] = 0;
      }
      s1[s[i]]++;

      if(!s2.ContainsKey(t[i])){
        s2[t[i]] = 0;
      }

      s2[t[i]]++;
     }

     foreach(var e in s1){
      if(!s2.ContainsKey(e.Key) || s2[e.Key] != e.Value){
        return false;
      }
     }
      return true;
     
    }
}
