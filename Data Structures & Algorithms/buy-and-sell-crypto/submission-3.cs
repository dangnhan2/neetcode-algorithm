public class Solution {
    public int MaxProfit(int[] prices) {
       int profit = 0;
       for(int i = 0; i < prices.Length; i++){
        for(int j = i; j < prices.Length; j++){
            profit = Math.Max(profit, prices[j] - prices[i]);
        }
       }

       return profit;
    }
}
