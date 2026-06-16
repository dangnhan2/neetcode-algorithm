public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int res = weights.Max();
        while(true){
            int ship = 1;
            int cap = res;
            foreach(int w in weights){
                if(cap - w < 0){
                    ship++;
                    cap = res;
                }

                cap -= w;
            }

            if(ship <= days){
                return res;
            }

            res++;
        }
    }
}