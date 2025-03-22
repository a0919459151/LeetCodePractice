using LeetCodePractice.BestTimeToBuyAndSellStock;

namespace LeetCodePractice.Test;

public class BestTimeToBuyAndSellStockTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        int[] input = [7, 1, 5, 3, 6, 4];
        int expected = 5;

        // Act
        BestTimeToBuyAndSellStock_Solution solution = new();
        var actual = solution.MaxProfit(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        int[] input = [7, 6, 4, 3, 1];
        int expected = 0;

        // Act
        BestTimeToBuyAndSellStock_Solution solution = new();
        var actual = solution.MaxProfit(input);

        // Assert
        Assert.Equal(expected, actual);
    }
}
