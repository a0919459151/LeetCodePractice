namespace _2.TwoSum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        if (nums.Length < 2) throw new ArgumentException(nameof(nums));

        // Two pointer
        var i = 0;
        var j = 1;


        // Move i
        while (i < nums.Length - 1)
        {
            // Move j
            while (j <= nums.Length - 1)
            {
                // Return answer
                if (CheckSumIsTarget(nums, target, i, j))
                {
                    return [i, j];
                }

                // j move next
                j++;
            }

            // Set next round i, j
            (i, j) = SetNextRoundIJ(i);
        }

        // No match result
        return [i, j];


        static bool CheckSumIsTarget(int[] nums, int target, int i, int j)
        {
            return nums[i] + nums[j] == target;
        }

        static (int, int) SetNextRoundIJ(int i)
        {
            return (i + 1, i + 2);
        }
    }
}
