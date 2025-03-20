using LeetCodePractice.NQueens;

namespace LeetCodePractice.Test;

public class NQueensTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        int n = 4;
        List<IList<string>> expected = [
             [
                ".Q..",
                "...Q",
                "Q...",
                "..Q."
            ],
            [
                "..Q.",
                "Q...",
                "...Q",
                ".Q.."
            ]
         ];

        // Act
        NQueens_Solution solution = new();
        List<IList<string>> actual = (List<IList<string>>)solution.SolveNQueens(n);
        
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        int n = 1;
        List<IList<string>> expected = [["Q"]];
        
        // Act
        NQueens_Solution solution = new();
        List<IList<string>> actual = (List<IList<string>>)solution.SolveNQueens(n);

        // Assert
        Assert.Equal(expected, actual);
    }
}
