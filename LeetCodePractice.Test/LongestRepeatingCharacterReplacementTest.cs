using LeetCodePractice.LongestRepeatingCharacterReplacement;

namespace LeetCodePractice.Test;

public class LongestRepeatingCharacterReplacementTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var input = "ABAB";
        var k = 2;
        var expected = 4;

        // Act
        LongestRepeatingCharacterReplacement_Solution solution = new();
        var actual = solution.CharacterReplacement(input, k);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        var input = "AABABBA";
        var k = 1;
        var expected = 4;

        // Act
        LongestRepeatingCharacterReplacement_Solution solution = new();
        var actual = solution.CharacterReplacement(input, k);

        // Assert
        Assert.Equal(expected, actual);
    }
}
