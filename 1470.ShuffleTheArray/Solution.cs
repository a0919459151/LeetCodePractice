namespace _1470.ShuffleTheArray;

public class Solution
{
    /// <summary>
    /// 洗牌
    /// </summary>
    /// <param name="nums">排堆</param>
    /// <param name="n">分組的大小</param>
    /// <returns></returns>
    public int[] Shuffle(int[] nums, int n)
    {
        List<int> result = new(nums.Length);

        Span<int> firstHalf = nums.AsSpan(0, n);
        Span<int> secondHalf = nums.AsSpan(n);

        for (int i = 0; i < n; i++)
        {
            result.Add(firstHalf[i]);
            result.Add(secondHalf[i]);
        }

        return result.ToArray();
    }
}
