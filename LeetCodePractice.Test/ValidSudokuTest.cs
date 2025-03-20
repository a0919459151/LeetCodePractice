using LeetCodePractice.ValidSudoku;

namespace LeetCodePractice.Test;

public class ValidSudokuTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        ValidSudoku_Solution solution = new();
        char[][] input = [
            ['5', '3', '.', '.', '7', '.', '.', '.', '.' ],
            ['6', '.', '.', '1', '9', '5', '.', '.', '.' ],
            ['.', '9', '8', '.', '.', '.', '.', '6', '.' ],
            ['8', '.', '.', '.', '6', '.', '.', '.', '3' ],
            ['4', '.', '.', '8', '.', '3', '.', '.', '1' ],
            ['7', '.', '.', '.', '2', '.', '.', '.', '6' ],
            ['.', '6', '.', '.', '.', '.', '2', '8', '.' ],
            ['.', '.', '.', '4', '1', '9', '.', '.', '5' ],
            ['.', '.', '.', '.', '8', '.', '.', '7', '9'],
        ];
        var expected = true;

        // Act
        var actual = solution.IsValidSudoku(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        char[][] input = [
            ['8', '3', '.', '.', '7', '.', '.', '.', '.' ],
            ['6', '.', '.', '1', '9', '5', '.', '.', '.' ],
            ['.', '9', '8', '.', '.', '.', '.', '6', '.' ],
            ['8', '.', '.', '.', '6', '.', '.', '.', '3' ],
            ['4', '.', '.', '8', '.', '3', '.', '.', '1' ],
            ['7', '.', '.', '.', '2', '.', '.', '.', '6' ],
            ['.', '6', '.', '.', '.', '.', '2', '8', '.' ],
            ['.', '.', '.', '4', '1', '9', '.', '.', '5' ],
            ['.', '.', '.', '.', '8', '.', '.', '7', '9'],
        ];
        var expected = false;

        // Act
        ValidSudoku_Solution solution = new();
        var actual = solution.IsValidSudoku(input);

        // Assert
        Assert.Equal(expected, actual);
    }
}
