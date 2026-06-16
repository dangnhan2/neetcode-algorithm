public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int buy=0;
        int sell = 1;
        while(sell < prices.Length){
            if(prices[sell] > prices[buy]){
                int tmp = prices[sell] - prices[buy];
                profit = Math.Max(profit, tmp);
            }else{
                buy = sell;
            }
            sell++;
        }
        return profit;
    }
}
