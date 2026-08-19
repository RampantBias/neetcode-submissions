public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0) return 0;
        int maxProfit = 0, minPrice = prices[0];
        foreach(int price in prices) {
            if (price < minPrice) {
                minPrice = price;
            }
            int profit = price - minPrice;
            maxProfit = Math.Max(maxProfit, profit);
        }
        return maxProfit;
    }
}
