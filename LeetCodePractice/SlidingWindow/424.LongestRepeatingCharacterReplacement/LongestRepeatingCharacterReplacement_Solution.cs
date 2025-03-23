namespace LeetCodePractice.LongestRepeatingCharacterReplacement;

public class LongestRepeatingCharacterReplacement_Solution
{
    public int CharacterReplacement(string s, int k)
    {
        var maxWindowLength = 0;
        var letterCountArr = new int[26];
        var left = 0;
        var right = 0;

        for (; right < s.Length; right++)
        {
            var rightLetter = s[right];
            IncreaseLetterCount(letterCountArr, rightLetter);

            bool isInValidSubstring = IsInvalidSubstring(k, letterCountArr, left, right);

            // 如果超出 k 的用量
            if (isInValidSubstring)
            {
                // 對應 letter count 減一
                var leftLetter = s[left];
                DecreaseLetterCount(letterCountArr, leftLetter);

                // 右移 left 指標
                left += 1;
            }

            // 紀錄最大窗口長度
            maxWindowLength = Math.Max(maxWindowLength, CalWindowLength(left, right));
        }

        return maxWindowLength;
    }

    // Is Invalid Substring
    private static bool IsInvalidSubstring(int k, int[] letterCountArr, int left, int right)
    {
        var countMax = letterCountArr.Max();
        var currentWindowLength = CalWindowLength(left, right);

        return currentWindowLength - countMax > k;
    }

    // Increase letter count
    private static void IncreaseLetterCount(int[] letterCountArr, char letter)
    {
        var letterPosition = GetLetterPosition(letter);
        letterCountArr[letterPosition] += 1;
    }

    // Decrease
    private static void DecreaseLetterCount(int[] letterCountArr, char letter)
    {
        var letterPosition = GetLetterPosition(letter);
        letterCountArr[letterPosition] -= 1;
    }

    // Get letter position
    private static int GetLetterPosition(char letter)
    {
        // A-Z is 0-25
        return char.ToUpper(letter) - 'A';
    }

    // Calculate window length
    private static int CalWindowLength(int left, int right)
    {
        return right - left + 1;
    }
}
