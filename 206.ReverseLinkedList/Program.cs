namespace _206.ReverseLinkedList;

class Program
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

        // 建立測試用的鏈表 [1,2,3,4,5]
        ListNode head = new(1, new(2, new(3, new(4, new(5, null)))));
    
        // 預期結果應該是 [5,4,3,2,1]
        ListNode expected = new(5, new(4, new(3, new(2, new(1, null)))));
    
        ListNode ans = solution.ReverseList(head); // 執行反轉
    
        // 驗證結果是否正確
        return CompareLinkedLists(ans, expected) ? "success" : "fail";
    }

    private static string Test2()
    {
        Solution solution = new();

        ListNode? head = null;
    
        ListNode? expected = null;
    
        ListNode ans = solution.ReverseList(head); // 執行反轉
    
        // 驗證結果是否正確
        return CompareLinkedLists(ans, expected) ? "success" : "fail";
    }

    private static string Test3()
    {
        Solution solution = new();

        ListNode? head = new(1);
    
        ListNode? expected = new(1);
    
        ListNode ans = solution.ReverseList(head); // 執行反轉
    
        // 驗證結果是否正確
        return CompareLinkedLists(ans, expected) ? "success" : "fail";
    }

    private static bool CompareLinkedLists(ListNode l1, ListNode l2)
    {
        while (l1 != null && l2 != null) 
        {
            if (l1.Val != l2.Val) return false;
            l1 = l1.Next;
            l2 = l2.Next;
        }
        return l1 == null && l2 == null;
    }
}