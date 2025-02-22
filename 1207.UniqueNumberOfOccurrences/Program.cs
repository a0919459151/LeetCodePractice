namespace _1207.UniqueNumberOfOccurrences;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Test1: {Test1()}");
    }

    private static string Test1()
    {
        Solution solution = new();

        int[] input = [1, 2, 2, 1, 1, 3];

        var expect = true;

        var ans = solution.UniqueOccurrences(input);

        return ans == expect ? "success" : "fail";
    }
}
