using LeetCodePractice.LinkedListCycle;

namespace LeetCodePractice.Test;

public class LinkedListCycleTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        // head = [3,2,0,-4], pos = 1
        ListNode node1 = new(3);
        ListNode node2 = new(2);
        ListNode node3 = new(0);
        ListNode node4 = new(-4);
        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node2; // pos = 1, 形成環 (指向 node2)
        var expected = true;

        // Act
        LinkedListCycle_Solution solution = new();
        bool actual = solution.HasCycle(node1);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        // head = [], pos = -1
        var expected = false;

        // Act
        LinkedListCycle_Solution solution = new();
        bool actual = solution.HasCycle(null);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        // Arrange
        // head = [1,2], pos = -1
        ListNode node1 = new(1);
        ListNode node2 = new(2);
        node1.next = node2;
        node2.next = null;
        var expected = false;

        // Act
        LinkedListCycle_Solution solution = new();
        bool actual = solution.HasCycle(node1);

        // Assert
        Assert.Equal(expected, actual);
    }
}
