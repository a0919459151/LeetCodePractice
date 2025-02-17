namespace _1207.UniqueNumberOfOccurrences;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Test1: {Test1()}");
    }

    private static string Test1()
    {
        int[] input = [1, 2, 2, 1, 1, 3];

        var expect = true;

        var ans = Solution.UniqueOccurrences(input);

        return ans == expect
            ? "success"
            : "fail";
    }
}


public class Solution
{
    public static bool UniqueOccurrences(int[] arr)
    {
        // Calculate number count
        Dictionary<int, int> numberCountDic = CalculateNumberCount(arr);

        return IsCountUnique(numberCountDic);

 
        static Dictionary<int, int> CalculateNumberCount(int[] arr)
        {
            Dictionary<int, int> numberCountDic = new();

            foreach (var ele in arr)
            {
                // Element exists
                if (numberCountDic.TryGetValue(ele, out int value))
                {
                    numberCountDic[ele] = value + 1;
                }
                // Element not exists
                else
                {
                    numberCountDic.Add(ele, 1);
                }
            }

            return numberCountDic;
        }
        static bool IsCountUnique(Dictionary<int, int> numberCountDic)
        {
            HashSet<int> set = new();

            foreach (var kv in numberCountDic)
            {
                if (!set.Add(kv.Value))
                {
                    // Element is already present
                    return false;
                }
            }

            // Is unique
            return true;
        }
    }
}