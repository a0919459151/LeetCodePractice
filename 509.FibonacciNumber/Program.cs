namespace _509.FibonacciNumber;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Test1: {Test1()}");
        Console.WriteLine($"Test2: {Test2()}");
        Console.WriteLine($"Test3: {Test3()}");
    }

    private static string Test1()
    {
        Solution solution = new();
        var input = 2;
        var expect = 1;
        var ans = solution.Fib(input);
        return ans == expect ? "success" : "fail";
    }

    private static string Test2()
    {
        Solution solution = new();
        var input = 3;
        var expect = 2;
        var ans = solution.Fib(input);
        return ans == expect ? "success" : "fail";
    }

    private static string Test3()
    {
        Solution solution = new();
        var input = 4;
        var expect = 3;
        var ans = solution.Fib(input);
        return ans == expect ? "success" : "fail";
    }
}
