using LeetCodePractice.IsSubsequence;

namespace LeetCodePractice.Test;

public class IsSubsequenceTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        string input_s = "abc";
        string input_t = "ahbgdc";
        var expected = true;

        // Act
        IsSubsequence_Solution solution = new();
        var actual = solution.IsSubsequence(input_s, input_t);

        // Assert
        Assert.True(actual == expected);
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        string input_s = "axc";
        string input_t = "ahbgdc";
        var expected = false;
        
        // Act
        IsSubsequence_Solution solution = new();
        var actual = solution.IsSubsequence(input_s, input_t);
        
        // Assert
        Assert.True(actual == expected);
    }
}
