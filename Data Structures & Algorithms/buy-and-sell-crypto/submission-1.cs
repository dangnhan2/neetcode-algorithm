public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int buy=0;
        int sell = 1;
        while(sell < prices.Length){
            while(prices[sell] -prices[buy] < 0 ) buy++;
            int tmp = prices[sell] -prices[buy];
            if( tmp > profit){
                profit = tmp;
            }
            sell++;
        }
        return profit;
    }
}
