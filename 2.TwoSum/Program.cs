namespace _2.TwoSum;

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

        int[] input = [2, 7, 11, 15];
        int target = 9;

        int[] expect = [0, 1];

        var ans = solution.TwoSum(input, target);

        return ans.SequenceEqual(expect) ? "success" : "fail";
    }

    private static string Test2()
    {
        Solution solution = new();

        int[] input = [3, 2, 4];
        int target = 6;

        int[] expect = [1, 2];

        var ans = solution.TwoSum(input, target);

        return ans.SequenceEqual(expect) ? "success" : "fail";
    }
}
