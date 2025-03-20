namespace LeetCodePractice.FindClosestNumberToZero;

public class FindClosestNumberToZero_Solution
{
    public int FindClosestNumber(int[] nums)
    {
        int closest = nums[0];

        foreach (var num in nums)
        {
            if (IsCloser(num, closest)
                || IsEqualAndGreater(num, closest))
            {
                closest = num;
            }
        }

        return closest;
    }
    private static bool IsCloser(int num, int closest)
    {
        return Math.Abs(num) < Math.Abs(closest);
    }
    private static bool IsEqualAndGreater(int num, int closest)
    {
        return Math.Abs(num) == Math.Abs(closest) && num > closest;
    }
}
