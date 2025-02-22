namespace _141.LinkedListCycle;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Test1: {Test1()}");
        Console.WriteLine($"Test2: {Test2()}");
        Console.WriteLine($"Test3: {Test3()}");
    }

    private static string Test1()
    {
        Solution solution = new();

        // head = [3,2,0,-4], pos = 1
        ListNode node1 = new(3);
        ListNode node2 = new(2);
        ListNode node3 = new(0);
        ListNode node4 = new(-4);

        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node2; // pos = 1, 形成環 (指向 node2)

        var expect = true;

        bool ans = solution.HasCycle(node1);

        return ans == expect ? "success" : "fail";
    }

    private static string Test2()
    {
        Solution solution = new();

        // head = [], pos = -1

        var expect = false;

        bool ans = solution.HasCycle(null);

        return ans == expect ? "success" : "fail";
    }

    private static string Test3()
    {
        Solution solution = new();

        // head = [1,2], pos = -1
        ListNode node1 = new(1);
        ListNode node2 = new(2);

        node1.next = node2;
        node2.next = null;

        var expect = false;

        bool ans = solution.HasCycle(node1);

        return ans == expect ? "success" : "fail";
    }
}
