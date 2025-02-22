namespace _345.ReverseVowelsOfAString;

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

        var str = "IceCreAm";
        var expect = "AceCreIm";

        var ans = solution.ReverseVowels(str);

        return ans == expect ? "success" : "fail";
    }

    private static string Test2()
    {
        Solution solution = new();

        var str = "leetcode";
        var expect = "leotcede";

        var ans = solution.ReverseVowels(str);

        return ans == expect ? "success" : "fail";
    }

    private static string Test3()
    {
        Solution solution = new();

        var str = " ";
        var expect = " ";

        var ans = solution.ReverseVowels(str);

        return ans == expect ? "success" : "fail";
    }
}

