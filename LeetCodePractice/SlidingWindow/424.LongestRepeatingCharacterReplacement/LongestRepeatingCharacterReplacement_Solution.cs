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
            var rightLetterPosition = GetLetterPosition(s[right]);
            letterCountArr[rightLetterPosition] += 1;

            var countMax = letterCountArr.Max();
            var currentWindowLength = right - left + 1;

            var isInValidSubstring = currentWindowLength - countMax > k;

            // 如果超出 k 的用量
            if (isInValidSubstring)
            {
                // 對應 letter count 減一
                var leftLetterPosition = GetLetterPosition(s[left]);
                letterCountArr[leftLetterPosition] -= 1;

                // 右移 left 指標
                left += 1;

                // 重算 currentWindowLength
                currentWindowLength = (right - left + 1);
            }

            // 紀錄最大窗口長度
            maxWindowLength = Math.Max(maxWindowLength, currentWindowLength);
        }

        return maxWindowLength;
    }

    // Get Position
    private int GetLetterPosition(char letter)
    {
        // A-Z is 0-25
        return char.ToUpper(letter) - 'A';
    }
}
