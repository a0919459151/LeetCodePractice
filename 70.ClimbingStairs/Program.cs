
namespace _70.ClimbingStairs;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Test1: {Test1()}");
        Console.WriteLine($"Test2: {Test2()}");
    }

    private static string Test1()
    {
        var input = 2;

        var expect = 2;

        var ans = Solution.ClimbStairs(input);

        return ans == expect
            ? "success"
            : "fail";
    }

    private static string Test2()
    {
        var input = 3;

        var expect = 3;


        var ans = Solution.ClimbStairs(input);

        return ans == expect
            ? "success"
            : "fail";
    }
}


public class Solution
{
    private static Dictionary<int, int> _cache = new();

    public static int ClimbStairs(int n)
    {
        if (n == 1) return 1;
        if (n == 2) return 2;

        if (_cache.ContainsKey(n)) return _cache[n];

        var res = ClimbStairs(n - 1) + ClimbStairs(n - 2);

        _cache[n] = res;

        return res;
    }
}
