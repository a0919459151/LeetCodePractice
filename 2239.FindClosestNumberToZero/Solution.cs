namespace _2239.FindClosestNumberToZero;

public class Solution
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

        static bool IsCloser(int num, int closest)
        {
            return Math.Abs(num) < Math.Abs(closest);
        }
        static bool IsEqualAndGreater(int num, int closest)
        {
            return Math.Abs(num) == Math.Abs(closest) && num > closest;
        }
    }
}
