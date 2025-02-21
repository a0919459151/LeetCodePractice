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
        int[] input = [-4, -2, 1, 4, 8];

        var expect = 1;

        var ans = Solution.FindClosestNumber(input);
        
        return ans == expect 
            ? "success" 
            : "fail";
    }
    
    private static string Test2()
    {
        int[] input = [2, -1, 1];

        var expect = 1;

        var ans = Solution.FindClosestNumber(input);
        
        return ans == expect 
            ? "success" 
            : "fail";
    }
}

public class Solution 
{
    public static int FindClosestNumber(int[] nums) 
    {
        int closest = nums[0];
    
        foreach (var num in nums)
        {
            if (IsCloser(num, closest) 
                || IsEqualAndGreater(num, closest))
            {
                closest = num;
            }
        }

        return closest;

        static bool IsCloser(int num, int closest)
        {
            return Math.Abs(num) < Math.Abs(closest);
        }
        static bool IsEqualAndGreater(int num, int closest)
        {
            return Math.Abs(num) == Math.Abs(closest) && num > closest;
        }
    }
}
