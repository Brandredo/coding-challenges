public class Solution {
    public int MaxProfit(int[] prices) {
        
        int maxProfit = 0;

        if(prices.Length == 0 || prices.Length == 1) return 0;

        int minBuyPriceSoFar = prices[0];
        int start = 0;

        for(int end = 1; end < prices.Length; end++) {

            int profit = prices[end] - prices[start];
            maxProfit = Math.Max(maxProfit, profit);

            if(prices[end] < minBuyPriceSoFar) {
                start = end;
                minBuyPriceSoFar = prices[end];
            }

        }

        return maxProfit;


    }
}


// [2,1,0,5]
//      b
//        e


