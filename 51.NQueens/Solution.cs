using System.Text;

namespace _51.NQueens;

public class Solution
{
    public IList<IList<string>> SolveNQueens(int n)
    {
        List<IList<string>> result = new();
        
        Chessboard chessboard = new(n);

        TryPlaceQueen(chessboard, result, n);

        return result;
    }

    // Try place queen
    private static void TryPlaceQueen(Chessboard chessboard, List<IList<string>> result, int n, int row = 0)
    {
        // Is already placed n queens, store the result
        if (row == n)
        {
            result.Add(new List<string>(chessboard.CurrentValue));
            return;
        }

        for (int col = 0; col < n; col++)
        {
            // If the place is invalid, continue
            if (chessboard.IsInvalidPlace(row, col)) continue;

            // Place the queen
            chessboard.PlaceQueen(row, col);

            // Try place the queen in the next row
            TryPlaceQueen(chessboard, result, n, row + 1);

            // Take back the queen
            chessboard.TakeBackQueen(row, col);
        }
    }
}


public class Chessboard
{
    // n-queens chessboard
    private readonly int _n;

    public List<string> CurrentValue { get; } = new();
    public InValidPlace InvalidPlace { get; } = new();


    public Chessboard(int n)
    {
        _n = n;
    }

    // Place the queen
    public void PlaceQueen(int row, int col)
    {
        CurrentValue.Add(GenerateRow(col, _n));
        InvalidPlace.Add(row, col);

        static string GenerateRow(int col, int n)
        {
            StringBuilder sb = new();
            for (int i = 0; i < n; i++)
            {
                sb.Append(i == col ? 'Q' : '.');
            }
            return sb.ToString();
        }
    }

    // Take back the queen
    public void TakeBackQueen(int row, int col)
    {
        CurrentValue.RemoveAt(CurrentValue.Count - 1);
        InvalidPlace.Remove(row, col);
    }

    // Is invalid place
    public bool IsInvalidPlace(int row, int col)
    {
        return InvalidPlace.IsInvalid(row, col);
    }
}


public class InValidPlace
{
    // Set of invalid vertical place
    private HashSet<int> _vertical = new();

    /* positive diagonal : col + row 
    ^   <--- col ---->
    |      0  1  2  3
    |   0 [0][1][2][3]
    row 1 [1][2][3][4]
    |   2 [2][3][4][5]
    v   3 [3][4][5][6]
    */
    // Set of invalid positive diagonal place
    private HashSet<int> _positiveDiagonal = new();

    /* negative diagonal : col - row
    ^   <--- col ---->
    |      0   1   2   3
    |   0 [0] [1] [2] [3]
    row 1 [-1][0] [1] [2]
    |   2 [-2][-1][0] [1]
    v   3 [-3][-2][-1][0]
    */
    // Set of invalid negative diagonal place
    private HashSet<int> _negativeDiagonal = new();

    // Add invalid place
    public void Add(int row, int col)
    {
        _vertical.Add(col);
        _positiveDiagonal.Add(row + col);
        _negativeDiagonal.Add(col - row);
    }

    // Remove invalid place
    public void Remove(int row, int col)
    {
        _vertical.Remove(col);
        _positiveDiagonal.Remove(row + col);
        _negativeDiagonal.Remove(col - row);
    }

    // Check if the place is invalid
    public bool IsInvalid(int row, int col)
    {
        return _vertical.Contains(col) || _positiveDiagonal.Contains(row + col) || _negativeDiagonal.Contains(col - row);
    }
}