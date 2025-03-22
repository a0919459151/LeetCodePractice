namespace LeetCodePractice.BestTimeToBuyAndSellStock;

public class BestTimeToBuyAndSellStock_Solution
{
    // 暴力解法 -> 超時
    //public int MaxProfit(int[] prices)
    //{
    //    int buyDay;
    //    int sellDay;

    //    int maxProfit = 0;

    //    for (buyDay = 0; buyDay < prices.Length - 1; buyDay++)
    //    {
    //        int buyPrice = prices[buyDay];

    //        for (sellDay = buyDay + 1; sellDay < prices.Length; sellDay++)
    //        {
    //            int sellPrice = prices[sellDay];

    //            int currProfit = sellPrice - buyPrice;

    //            if (currProfit > maxProfit)
    //            {
    //                maxProfit = currProfit;
    //            }
    //        }
    //    }

    //    return maxProfit;
    //}

    /// <summary>
    /// 計算股票的最大獲利，只能選擇一天買入、一天賣出，且賣出日需在買入日之後。
    /// 若無法獲利則回傳 0。
    /// </summary>
    /// <param name="prices">整數陣列，表示每天的股票價格</param>
    /// <returns>整數，代表最大獲利金額</returns>
    public int MaxProfit(int[] prices)
    {
        // 記錄歷史最低買入價格，初始值設為 int.MaxValue，確保第一天價格能正常更新
        int minPrice = int.MaxValue;

        // 記錄最大獲利，初始值為 0，表示如果無法獲利則回傳 0
        int maxProfit = 0;

        // 遍歷整個價格陣列
        foreach (var currPrice in prices)
        {
            // 更新歷史最低買入價格 (確保選擇最低點買入)
            minPrice = Math.Min(minPrice, currPrice);

            // 計算當前價格與歷史最低買入價格之間的獲利，並更新最大獲利
            maxProfit = Math.Max(maxProfit, currPrice - minPrice);
        }

        // 回傳最大獲利
        return maxProfit;
    }
}
