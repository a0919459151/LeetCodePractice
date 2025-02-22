namespace _392.IsSubsequence;

public class Solution
{
    public bool IsSubsequence(string s, string t)
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
