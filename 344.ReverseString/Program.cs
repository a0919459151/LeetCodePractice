
namespace _344.ReverseString;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine($"Test1: {Test1()}");
    }

    private static object Test1()
    {
        var arr = "Hello World";
        var expect = "dlroW olleH";

        var ans = new string(Solution.ReverseString(arr.ToCharArray()));

        return ans == expect
            ? "success"
            : "fail";
    }
}

public class Solution
{
    public static char[] ReverseString(char[] charArray)
    {
        // Two pointer i, j
        var i = 0;
        var j = charArray.Length - 1;

        while (i < j)
        {
            SwapCharArrayValue(charArray, i, j);
            i++;
            j--;
        }

        return charArray;

        static void SwapCharArrayValue(char[] charArray, int i, int j)
        {
            var tempIValue = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = tempIValue;
        }
    }
}
