using System;

namespace StocksBuySell
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = new int[] { 7, 1, 5, 3, 6, 4 };
            var op = calculate(prices, 0);
            var o = maxprofit(prices);
            var p = maxprofit(prices);
        }

        static int calculate(int[] prices, int s)
        {
            if (s >= prices.Length)
                return 0;
            int max = 0;
            for (int start = s; start < prices.Length; start++)
            {
                int maxProfit = 0;
                for (int i = start + 1; i < prices.Length; i++)
                {
                    if (prices[start] < prices[i])
                    {
                        int profit = prices[i] - prices[start] + calculate(prices, i + 1);

                        maxProfit = Math.Max(maxProfit, profit);
                    }
                }
                max = Math.Max(max, maxProfit);
            }
            return max;
        }

        static int maxprofit(int[] prices)
        {
            int i = 0;
            int maxprofit = 0;
            int valley = prices[0];
            int peak = prices[0];

            while (i < prices.Length - 1)
            {
                while (i < prices.Length - 1 && prices[i + 1] <= prices[i])
                {
                    i++;
                }
                valley = prices[i];
                while (i < prices.Length - 1 && prices[i + 1] >= prices[i])
                {
                    i++;
                }
                peak = prices[i];
                maxprofit += peak - valley;
            }
            return maxprofit;
        }

        static int maxprofit1(int[] prices)
        {
            int maxprofit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    maxprofit += prices[i] - prices[i - 1];
                }
            }

            return maxprofit;
        }
    }
}
