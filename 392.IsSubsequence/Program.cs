namespace _392.IsSubsequence;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Test1: {Test1()}");
        Console.WriteLine($"Test2: {Test2()}");
    }

    private static string Test1()
    {
        string input_s = "abc";
        string input_t = "ahbgdc";

        var expect = true;

        var ans = Solution.IsSubsequence(input_s, input_t);

        return ans == expect
            ? "success"
            : "fail";
    }

    private static string Test2()
    {
        string input_s = "axc";
        string input_t = "ahbgdc";

        var expect = false;

        var ans = Solution.IsSubsequence(input_s, input_t);

        return ans == expect
            ? "success"
            : "fail";
    }
}

public class Solution 
{
    public static bool IsSubsequence(string s, string t)
    {
        int s_pointer = 0;
        int t_pointer = 0;

        while (s_pointer < s.Length && t_pointer < t.Length)
        {
            // If characters match, advance both s_pointer and t_pointer by one
            if (s[s_pointer] == t[t_pointer])
            {
                s_pointer += 1;  
                t_pointer += 1;
            }
            // If characters do not match, advance only t_pointer by one
            else
            {
                t_pointer += 1;
            }
        }

        return s_pointer == s.Length;
    }
}