namespace _344.ReverseString;

public class Solution
{
    public char[] ReverseString(char[] charArray)
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
