public class Solution {
    public int ScoreOfString(string s) {
        int score = 0;
        var e0 = s[0];
        for(int i=1 ; i < s.Length; i++){
            score += Math.Abs(s[i] - e0);
            e0 = s[i];
        }

        return score;
    }
}