namespace _344.ReverseString;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Test1: {Test1()}");
    }

    private static string Test1()
    {
        Solution solution = new();

        var arr = "Hello World";
        var expect = "dlroW olleH";

        var ans = new string(solution.ReverseString(arr.ToCharArray()));

        return ans == expect ? "success" : "fail";
    }
}
