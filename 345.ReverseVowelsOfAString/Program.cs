namespace _345.ReverseVowelsOfAString;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Test1: {Test1()}");
        Console.WriteLine($"Test2: {Test2()}");
        Console.WriteLine($"Test3: {Test3()}");
    }

    private static string Test1()
    {
        var str = "IceCreAm";
        var expect = "AceCreIm";

        return Solution.ReverseVowels(str) == expect
            ? "success"
            : "fail";
    }

    private static string Test2()
    {
        var str = "leetcode";
        var expect = "leotcede";

        return Solution.ReverseVowels(str) == expect
            ? "success"
            : "fail";
    }

    private static string Test3()
    {
        var str = " ";
        var expect = " ";

        return Solution.ReverseVowels(str) == expect
            ? "success"
            : "fail";
    }
}

public class Solution
{
    public static string ReverseVowels(string s)
    {
        char[] charArray = s.ToCharArray();

        // Two pointer i, j
        var i = 0;
        var j = charArray.Length - 1;

        while (true)
        {
            i = GetLeftVowelCharIndex(charArray, ref i);
            j = GetRightVowelCharIndex(charArray, ref j);

            if (i >= j) break;

            SwapCharArrayValue(charArray, i, j);
            i++;
            j--;
        }

        return new string(charArray);


        static void SwapCharArrayValue(char[] charArray, int i, int j)
        {
            var tempIValue = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = tempIValue;
        }
        static int GetLeftVowelCharIndex(char[] charArray, ref int i)
        {
            if (i > charArray.Length - 1)
            {
                return i;
            }
            if (IsVowel(charArray[i]))
            {
                return i;
            }
            i++;
            return GetLeftVowelCharIndex(charArray, ref i);
        }
        static int GetRightVowelCharIndex(char[] charArray, ref int j)
        {
            if (j < 0)
            {
                return j;
            }
            if (IsVowel(charArray[j]))
            {
                return j;
            }
            j--;
            return GetRightVowelCharIndex(charArray, ref j);
        }
        static bool IsVowel(char c)
        {
            char[] vowels = ['a', 'e', 'i', 'o', 'u'];
            return vowels.Contains(Char.ToLower(c));
        }
    }
}