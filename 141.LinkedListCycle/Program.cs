namespace _141.LinkedListCycle;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Test1: {Test1()}");
        Console.WriteLine($"Test2: {Test2()}");
        Console.WriteLine($"Test3: {Test3()}");
    }

    private static string Test1()
    {
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

        bool ans = Solution.HasCycle(node1);

        return ans == expect 
            ? "success" 
            : "fail";
    }

    private static string Test2()
    {
        // head = [], pos = -1

        var expect = false;

        bool ans = Solution.HasCycle(null);

        return ans == expect
            ? "success"
            : "fail";
    }

    private static string Test3()
    {
        // head = [1,2], pos = -1
        ListNode node1 = new(1);
        ListNode node2 = new(2);

        node1.next = node2;
        node2.next = null;

        var expect = false;

        bool ans = Solution.HasCycle(node1);

        return ans == expect
            ? "success"
            : "fail";
    }
}

public class Solution
{
    public static bool HasCycle(ListNode? head)
    {
        if (head is null) return false;

        // Init hash set
        HashSet<ListNode> hashSet = new();

        ListNode currentNode = head;
        ListNode? nextNode = head.next;

        // Loop
        while(true)
        {
            // If next node is null, return answer false 
            if (nextNode is null)
            {
                return false;
            }

            // If hashSet contains current node, return answer true
            if (hashSet.Contains(currentNode))
            {
                return true;
            }

            // Add node to set
            hashSet.Add(currentNode);

            // Move next round
            (currentNode, nextNode) = MoveNextRound(nextNode);
        }

        static (ListNode , ListNode?) MoveNextRound(ListNode nextNode)
        {
            return (nextNode, nextNode.next);
        }
    }
}


/// <summary>
/// Definition for singly-linked list.
/// </summary>
public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}