using LeetCodePractice.ReverseVowelsOfAString;

namespace LeetCodePractice.Test;

public class ReverseVowelsOfAStringTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        ReverseVowelsOfAString_Solution solution = new();
        var str = "IceCreAm";
        var expected = "AceCreIm";

        // Act
        var actual = solution.ReverseVowels(str);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        ReverseVowelsOfAString_Solution solution = new();
        var str = "leetcode";
        var expected = "leotcede";

        // Act
        var actual = solution.ReverseVowels(str);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        // Arrange
        var str = " ";
        var expected = " ";

        // Act
        ReverseVowelsOfAString_Solution solution = new();
        var actual = solution.ReverseVowels(str);

        // Assert
        Assert.Equal(expected, actual);
    }
}
