public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int l = weights.Max();
        int h = weights.Sum();
        int res = h;

        bool CanShip(int cap){
            int ships = 1;
            int currCap = cap;
            foreach(int w in weights){
                if(currCap - w < 0){
                    ships++;
                    if(ships > days) return false;
                    currCap = cap;
                }
                currCap -= w;
            }

            return true;
        }

        while(l <= h){
           int cap = (l + h) / 2;
           if(CanShip(cap)){
            res = Math.Min(res, cap);
            h = cap -1;
           }else{
            l = cap + 1;
           }
        }

        return res;
    }


}