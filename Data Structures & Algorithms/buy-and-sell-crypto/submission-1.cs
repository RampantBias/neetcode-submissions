public class Solution {
    public int MaxProfit(int[] prices) {
        int buyPrice = prices[0];
        int maxProfit = 0;
        foreach(var price in prices) {
            buyPrice = Math.Min(buyPrice, price);
            maxProfit = Math.Max(maxProfit, price - buyPrice);
        }
        return maxProfit;
    }
}
