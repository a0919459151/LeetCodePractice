using LeetCodePractice.ReverseString;

namespace LeetCodePractice.Test;

public class ReverseStringTest
{

    [Fact]
    public void Test1()
    {
        // Arrange
        ReverseString_Solution solution = new();
        char[] input = ['h', 'e', 'l', 'l', 'o'];
        char[] expected = ['o', 'l', 'l', 'e', 'h'];

        // Act
        solution.ReverseString(input);

        // Assert
        Assert.Equal(expected, input);
    }

    [Fact]
    public void Test2()
    {
        // Arrange

        var input = new char[] { 'H', 'a', 'n', 'n', 'a', 'h' };
        var expected = new char[] { 'h', 'a', 'n', 'n', 'a', 'H' };

        // Act
        ReverseString_Solution solution = new();
        solution.ReverseString(input);

        // Assert
        Assert.Equal(expected, input);
    }
}
