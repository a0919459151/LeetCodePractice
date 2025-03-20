using LeetCodePractice.FibonacciNumber;

namespace LeetCodePractice.Test;

public class FibonacciNumberTest
{
    [Theory]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    public void Test1(int n, int expected)
    {
        // Arrange

        // Act
        FibonacciNumber_Solution solution = new();
        int result = solution.Fib(n);

        // Assert
        Assert.Equal(expected, result);
    }
}
