
namespace _51.NQueens;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Test1: {Test1()}");
        Console.WriteLine($"Test2: {Test2()}");
    }

    private static string Test1()
    {
        Solution solution = new();

        int input = 4;

        List<IList<string>> expect = [
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

        var ans = solution.SolveNQueens(input);

        return IsEqual(expect, ans) ? "success" : "fail";
    }

    private static string Test2()
    {
        Solution solution = new();

        int input = 1;

        List<IList<string>> expect = [["Q"]];

        var ans = solution.SolveNQueens(input);

        return IsEqual(expect, ans) ? "success" : "fail";
    }

    private static bool IsEqual(IList<IList<string>> expect, IList<IList<string>> ans)
    {
        if (expect.Count != ans.Count)
        {
            return false;
        }
        for (int i = 0; i < expect.Count; i++)
        {
            if (expect[i].Count != ans[i].Count)
            {
                return false;
            }
            for (int j = 0; j < expect[i].Count; j++)
            {
                if (expect[i][j] != ans[i][j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}
