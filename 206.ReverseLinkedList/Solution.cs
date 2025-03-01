namespace _206.ReverseLinkedList;

public class Solution 
{
    public ListNode? ReverseList(ListNode? head)
    {
        if (head is null) return null;
        if (head.Next is null) return head;

        ListNode prev = null!;
        ListNode current = head;
        ListNode? nextTemp = head.Next;
        
        // Try next until next node is null
        while (current != null)
        {
            // Reverse current next node
            current.Next = prev;

            // Next round
            prev = current;
            current = nextTemp;

            if (current is null)
            {
                return current;
            }
        }
    }
}