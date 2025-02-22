namespace _392.IsSubsequence;

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

        string input_s = "abc";
        string input_t = "ahbgdc";

        var expect = true;

        var ans = solution.IsSubsequence(input_s, input_t);

        return ans == expect ? "success" : "fail";
    }

    private static string Test2()
    {
        Solution solution = new();

        string input_s = "axc";
        string input_t = "ahbgdc";

        var expect = false;

        var ans = solution.IsSubsequence(input_s, input_t);

        return ans == expect ? "success" : "fail";
    }
}
