﻿namespace _70.ClimbingStairs;

public class Solution
{
    private Dictionary<int, int> _cache = new();

    // tips: Recursion + Memoization
    public int ClimbStairs(int n)
    {
        if (n == 1) return 1;
        if (n == 2) return 2;

        if (_cache.ContainsKey(n)) return _cache[n];

        var res = ClimbStairs(n - 1) + ClimbStairs(n - 2);

        _cache[n] = res;

        return res;
    }
}
