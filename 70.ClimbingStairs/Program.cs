
namespace _70.ClimbingStairs;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Test1: {Test1()}");
        Console.WriteLine($"Test2: {Test2()}");
        Console.WriteLine($"Test3: {Test3()}");
        Console.WriteLine($"Test4: {Test4()}");
    }

    private static string Test1()
    {
        var input = 2;

        // 1階 + 1階
        // 2階
        // 總共有 2 種走法
        var expect = 2;

        var ans = Solution.ClimbStairs(input);

        return ans == expect
            ? "success"
            : "fail";
    }

    private static string Test2()
    {
        var input = 3;

        // 退一步 1 階 : 2個階梯, 有 2 種走法
        // 退一步 2 階 : 1個階梯, 有 1 種走法
        // 總共有 3 種走法
        var expect = 3;

        var ans = Solution.ClimbStairs(input);

        return ans == expect
            ? "success"
            : "fail";
    }

    private static string Test3()
    {
        var input = 4;

        // 退一步 1 階 : 3個階梯, 有 3 種走法
        // 退一步 2 階 : 2個階梯, 有 2 種走法
        // 總共有 5 種走法
        var expect = 5;

        var ans = Solution.ClimbStairs(input);

        return ans == expect
            ? "success"
            : "fail";
    }

    private static string Test4()
    {
        var input = 5;

        // 退一步 1 階 : 4個階梯, 有 5 種走法
        // 退一步 2 階 : 3個階梯, 有 3 種走法
        // 總共有 8 總走法
        var expect = 8;

        var ans = Solution.ClimbStairs(input);

        return ans == expect
            ? "success"
            : "fail";
    }
}


public class Solution
{
    private static Dictionary<int, int> _cache = new();

    // tips: Recursion + Memoization
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
