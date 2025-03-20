namespace LeetCodePractice.ReverseVowelsOfAString;

public class ReverseVowelsOfAString_Solution
{
    private static readonly HashSet<char> _vowels = ['a', 'e', 'i', 'o', 'u'];

    public string ReverseVowels(string s)
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
    }

    private static void SwapCharArrayValue(char[] charArray, int i, int j)
    {
        (charArray[i], charArray[j]) = (charArray[j], charArray[i]);
    }

    private static int GetLeftVowelCharIndex(char[] charArray, int i)
    {
        // Find next vowel
        while (i < charArray.Length && !IsVowel(charArray[i]))
        {
            i++;
        }
        return i;
    }

    private static int GetRightVowelCharIndex(char[] charArray, int j)
    {
        while (j > 0 && !IsVowel(charArray[j]))
        {
            j--;
        }
        return j;
    }
    private static bool IsVowel(char c)
    {
        return _vowels.Contains(char.ToLower(c));
    }
}