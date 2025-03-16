namespace _509.FibonacciNumber;

public class Solution
{
    // Cache
    private readonly Dictionary<int, int> _cache = new();

    public int Fib(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        // If the fibResult is already calculated, return it early
        if (_cache.TryGetValue(n, out var fibResult))
        {
            return fibResult;
        }

        // Calculate the fibResult
        fibResult = Fib(n - 1) + Fib(n - 2);

        // Cache the fibResult
        _cache[n] = fibResult;

        return fibResult;
    }
}
