namespace _2.TwoSum;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine($"Test1: {Test1()}");
        Console.WriteLine($"Test2: {Test2()}");
    }

    private static string Test1()
    {
        int[] input = [2, 7, 11, 15];
        int target = 9;

        int[] expect = [0, 1];

        var ans = Solution.TwoSum(input, target);

        return ans.SequenceEqual(expect)
            ? "success"
            : "fail";
    }

    private static string Test2()
    {
        int[] input = [3, 2, 4];
        int target = 6;

        int[] expect = [1, 2];

        var ans = Solution.TwoSum(input, target);

        return ans.SequenceEqual(expect)
            ? "success"
            : "fail";
    }
}

public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        if (nums.Length < 2) throw new ArgumentException(nameof(nums));

        // Two pointer
        var i = 0;
        var j = 1;


        // Move i
        while (i < nums.Length - 1)
        {
            // Move j
            while (j <= nums.Length - 1)
            {
                // Return answer
                if (CheckSumIsTarget(nums, target, i, j))
                {
                    return [i, j];
                }

                // j move next
                j++;
            }

            // Set next around i, j
            i++;
            j = i + 1;
        }

        // No match result
        return [i, j];


        static bool CheckSumIsTarget(int[] nums, int target, int i, int j)
        {
            return nums[i] + nums[j] == target;
        }
    }
}
