namespace LeetCodePractice.UniqueNumberOfOccurrences;

public class UniqueNumberOfOccurrences_Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        // Calculate number count
        Dictionary<int, int> numberCountDic = CalculateNumberCount(arr);

        return IsCountUnique(numberCountDic);


        static Dictionary<int, int> CalculateNumberCount(int[] arr)
        {
            Dictionary<int, int> numberCountDic = new();

            foreach (var ele in arr)
            {
                // Element exists
                if (numberCountDic.TryGetValue(ele, out int value))
                {
                    numberCountDic[ele] = value + 1;
                }
                // Element not exists
                else
                {
                    numberCountDic.Add(ele, 1);
                }
            }

            return numberCountDic;
        }
    }

    private static bool IsCountUnique(Dictionary<int, int> numberCountDic)
    {
        HashSet<int> set = new();

        foreach (var kv in numberCountDic)
        {
            if (!set.Add(kv.Value))
            {
                // Element is already present
                return false;
            }
        }

        // Is unique
        return true;
    }
}
