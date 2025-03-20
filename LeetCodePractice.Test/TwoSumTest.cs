using LeetCodePractice.TwoSum;

namespace LeetCodePractice.Test;

public class TwoSumTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        int[] input = [2, 7, 11, 15];
        int target = 9;
        int[] expected = [0, 1];

        // Act
        TwoSum_Solution solution = new();
        var actual = solution.TwoSum(input, target);

        // Assert
        Assert.True(actual.SequenceEqual(expected));
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        TwoSum_Solution solution = new ();
        int[] input = [3, 2, 4];
        int target = 6;
        int[] expected = [1, 2];

        // Act
        var actual = solution.TwoSum(input, target);

        // Assert
        Assert.True(actual.SequenceEqual(expected));
    }
}