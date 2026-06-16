public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int length1 = word1.Length;
        int length2 = word2.Length;
        string res = "";
        for(int i=0; i< Math.Max(length1,length2); i++){
            if(i < length1){
               res += word1[i];
            }

            if(i < length2){
              res += word2[i];
            }
           
           
        }
        return res;
    }
}