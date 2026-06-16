public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length)
        return false;

        Dictionary<char,int> freq1 = new Dictionary<char,int>();
        for(int i = 0; i < s1.Length; i++){
            if(!freq1.ContainsKey(s1[i])){
                freq1[s1[i]] = 1;
            }else{
                freq1[s1[i]]++;
            }
        }
        
        int need = freq1.Count;
        for(int r = 0; r < s2.Length; r++){
           int cur = 0;
           Dictionary<char, int> freq2 = new Dictionary<char,int>();
           for(int l = r; l < s2.Length; l++){
              if(!freq2.ContainsKey(s2[l])){
                freq2[s2[l]] = 1;
              }else{
                freq2[s2[l]]++;
              }
              
              if(!freq1.ContainsKey(s2[l]) || freq1[s2[l]] < freq2[s2[l]]){
                break;
              }

              if(freq1[s2[l]] == freq2[s2[l]]){
                cur++;
              }

               if (cur == need) return true;
            }
                    
        }
        return false;
    }
}
