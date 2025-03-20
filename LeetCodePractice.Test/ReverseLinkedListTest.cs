using LeetCodePractice.ReverseLinkedList;

namespace LeetCodePractice.Test;

public class ReverseLinkedListTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        ListNode head = new(1, new(2, new(3, new(4, new(5)))));
        
        // Act
        ReverseLinkedList_Solution solution = new();
        ListNode actual = solution.ReverseList(head);
        
        // Assert
        Assert.Equal(5, actual.Val);
        Assert.Equal(4, actual.Next.Val);
        Assert.Equal(3, actual.Next.Next.Val);
        Assert.Equal(2, actual.Next.Next.Next.Val);
        Assert.Equal(1, actual.Next.Next.Next.Next.Val);
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        ListNode head = new(1, new(2));
        
        // Act
        ReverseLinkedList_Solution solution = new();
        ListNode actual = solution.ReverseList(head);
        
        // Assert
        Assert.Equal(2, actual.Val);
        Assert.Equal(1, actual.Next.Val);
    }
    [Fact]
    public void Test3()
    {
        // Arrange
        ListNode head = new(1);

        // Act
        ReverseLinkedList_Solution solution = new();
        ListNode actual = solution.ReverseList(head);

        // Assert
        Assert.Equal(1, actual.Val);
    }

}
