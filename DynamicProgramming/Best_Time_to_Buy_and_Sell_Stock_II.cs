using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms
{

  /// <summary>
  /// Input: prices = [7,1,5,3,6,4]
  // Output: 7
  // Explanation: Buy on day 2 (price = 1) and sell on day 3 (price = 5), profit = 5-1 = 4.
  // Then buy on day 4 (price = 3) and sell on day 5 (price = 6), profit = 6-3 = 3.
  // Total profit is 4 + 3 = 7.
  // https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
  /// </summary>
  public static class Best_Time_to_Buy_and_Sell_Stock_II
  {
    public static int MaxProfit(int[] prices)
    {
      int profit = 0;
      if (prices.Length <= 1)
        return profit;


      for (int i = 0; i < prices.Length - 1; i++) 
      {
        if (prices[i] < prices[i + 1])
        {
          profit += (prices[i + 1] - prices[i]);
        }

      }
      return profit;
    }
  }
}