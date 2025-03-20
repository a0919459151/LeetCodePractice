using LeetCodePractice.ShuffleTheArray;

namespace LeetCodePractice.Test;

public class ShuffleTheArrayTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        int[] nums = [2, 5, 1, 3, 4, 7];
        int n = 3;
        int[] expected = [2, 3, 5, 4, 1, 7];

        // Act
        ShuffleTheArray_Solution solution = new();
        int[] actual = solution.Shuffle(nums, n);

        // Assert
        Assert.Equal(expected, actual);
    }
}
