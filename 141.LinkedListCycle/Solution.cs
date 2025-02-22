namespace _141.LinkedListCycle;

public class Solution
{
    public bool HasCycle(ListNode? head)
    {
        if (head is null) return false;

        // Init hash set
        HashSet<ListNode> hashSet = new();

        ListNode currentNode = head;
        ListNode? nextNode = head.next;

        // Loop
        while (true)
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

        static (ListNode, ListNode?) MoveNextRound(ListNode nextNode)
        {
            return (nextNode, nextNode.next);
        }
    }
}
