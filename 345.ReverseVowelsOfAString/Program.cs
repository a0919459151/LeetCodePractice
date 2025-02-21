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
    private static readonly HashSet<char> _vowels = ['a', 'e', 'i', 'o', 'u'];

    public static string ReverseVowels(string s)
    {
        char[] charArray = s.ToCharArray();

        // Two pointer i, j
        var i = 0;
        var j = charArray.Length - 1;

        while (true)
        {
            i = GetLeftVowelCharIndex(charArray, i);
            j = GetRightVowelCharIndex(charArray, j);

            if (i >= j) break;

            SwapCharArrayValue(charArray, i, j);
            
            i++;
            j--;
        }

        return new string(charArray);


        static void SwapCharArrayValue(char[] charArray, int i, int j)
        {
            (charArray[i], charArray[j]) = (charArray[j], charArray[i]);
        }
        static int GetLeftVowelCharIndex(char[] charArray, int i)
        {
            // Find next vowel
            while (i < charArray.Length && !IsVowel(charArray[i]))
            {
                i++;
            }
            return i;
        }
        static int GetRightVowelCharIndex(char[] charArray, int j)
        {
            while (j > 0  && !IsVowel(charArray[j]))
            {
                j--;
            }
            return j;
        }
        static bool IsVowel(char c)
        {
            return _vowels.Contains(char.ToLower(c));
        }
    }
}