public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        
        int l =1;
        int r = piles.Max();
        int res = r;
        while(l <= r){
            int m = l + (r - l) /2;
            long hours = 0;
            foreach(int pile in piles){
                hours += (int)Math.Ceiling((double) pile/ m);
            }

            if(hours <= h){
                res = m;
                r = m - 1;
            }else{
                l = m + 1;
            }           
        }

        return res;
    }
}
