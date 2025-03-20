namespace LeetCodePractice.ReverseString;

public class ReverseString_Solution
{
    public void ReverseString(char[] s)
    {
        if (s.Length < 2) return;

        // Two pointer
        var i = 0;
        var j = s.Length - 1;

        while (i < j)
        {
            // Swap
            (s[i], s[j]) = (s[j], s[i]);
            i++;
            j--;
        }
    }
}
