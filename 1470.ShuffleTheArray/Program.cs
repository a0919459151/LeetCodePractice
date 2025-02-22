namespace _1470.ShuffleTheArray;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Test1: {Test1()}");
    }

    private static string Test1()
    {
        Solution solution = new();

        int[] nums = [2, 5, 1, 3, 4, 7];
        var n = 3;

        int[] expect = [2, 3, 5, 4, 1, 7];

        var ans = solution.Shuffle(nums, n);

        return ans.SequenceEqual(expect) ? "success" : "fail";
    }
}
