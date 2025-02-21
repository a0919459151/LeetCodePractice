namespace _392.IsSubsequence;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Test1: {Test1()}");

        static string Test1()
        {
            string input_s = "abc";
            string input_t = "ahbgdc";

            var expect = true;

            var ans = Solution.IsSubsequence(input_s, input_t);
            
            return ans == expect 
                ? "success" 
                : "fail";
        }
    }
    
}

public class Solution 
{
    public static bool IsSubsequence(string s, string t)
    {
        
        return false;
    }
}