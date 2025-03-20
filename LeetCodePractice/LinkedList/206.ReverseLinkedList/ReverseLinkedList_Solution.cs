namespace LeetCodePractice.ReverseLinkedList;

public class ReverseLinkedList_Solution 
{
    public ListNode? ReverseList(ListNode? head)
    {
        if (head is null) return null;

        ListNode? prev = null;
        ListNode current = head;

        while (true)
        {
            // Store next node
            ListNode? nextTemp = current.Next;

            // Reverse current next node
            current.Next = prev;

            // If next node is null, return current node
            if (nextTemp is null)
            {
                return current;
            }

            // Next round
            prev = current;
            current = nextTemp;
        }
    }
}

public class ListNode
{
    public int Val;
    public ListNode? Next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        Val = val;
        Next = next;
    }
}
