public class Solution {
    public int MaxProfit(int[] prices) {
       int profit = 0;
       int l = 0;
       for(int r = 0; r < prices.Length; r++){
        if(prices[l] > prices[r]){
            l = r;
        }

        profit = Math.Max(profit, prices[r] - prices[l]);
       }

       return profit;
    }
}
