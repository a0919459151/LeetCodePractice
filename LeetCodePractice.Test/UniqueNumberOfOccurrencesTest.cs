using LeetCodePractice.UniqueNumberOfOccurrences;

namespace LeetCodePractice.Test;

public class UniqueNumberOfOccurrencesTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        int[] input = [1, 2, 2, 1, 1, 3];
        var expected = true;

        // Act
        UniqueNumberOfOccurrences_Solution solution = new();
        bool actual = solution.UniqueOccurrences(input);

        // Assert
        Assert.Equal(expected, actual);
    }
}
