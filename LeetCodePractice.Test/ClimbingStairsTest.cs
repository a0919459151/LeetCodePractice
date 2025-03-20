using LeetCodePractice.ClimbingStairs;

namespace LeetCodePractice.Test;

public class ClimbingStairsTest
{
    [Theory]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    public void Test1(int n, int expected)
    {
        // Arrange

        // Act
        ClimbingStairs_Solution solution = new();
        int result = solution.ClimbStairs(n);

        // Assert
        Assert.Equal(expected, result);
    }
}
