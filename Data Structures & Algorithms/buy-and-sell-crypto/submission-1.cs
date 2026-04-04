public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = int.MinValue;
        int minBuy = 101;
        for(int i = 1; i < prices.Length; i++)
        {
            if(prices[i-1] < minBuy) minBuy = prices[i-1];
            int profit = prices[i] - minBuy;
            if(profit > maxProfit) maxProfit = profit;
        }
        if(maxProfit < 0 ) return 0;
        else return maxProfit;
    }
}
