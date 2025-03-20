using LeetCodePractice.FindClosestNumberToZero;

namespace LeetCodePractice.Test;

public class FindClosestNumberToZeroTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        int[] nums = [2, 5, 1, 3, 4, 7];
        int expected = 1;
        
        // Act
        FindClosestNumberToZero_Solution solution = new();
        int actual = solution.FindClosestNumber(nums);
        
        // Assert
        Assert.Equal(expected, actual);
    }
}
