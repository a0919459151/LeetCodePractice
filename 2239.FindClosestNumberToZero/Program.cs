namespace _2239.FindClosestNumberToZero;

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

        int[] input = [-4, -2, 1, 4, 8];

        var expect = 1;

        var ans = solution.FindClosestNumber(input);

        return ans == expect ? "success" : "fail";
    }

    private static string Test2()
    {
        Solution solution = new();

        int[] input = [2, -1, 1];

        var expect = 1;

        var ans = solution.FindClosestNumber(input);
        
        return ans == expect ? "success" : "fail";
    }
}
