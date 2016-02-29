    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) { return 0; }
            var maxSellPrice = new int[prices.Length];
            maxSellPrice[0] = prices[0];
            maxSellPrice[prices.Length-1] = prices[prices.Length-1];
            
            for (var i = prices.Length-2; i >= 0; i--)
            {
                maxSellPrice[i] = Math.Max(maxSellPrice[i + 1], prices[i]);
            }
            return Math.Abs(prices.Zip(maxSellPrice, (x, y) => x - y).Min());

        }
    }
