/*
You are given two non-empty linked lists representing two non-negative integers. 
The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Input: 
l1 = [2,4,3]
l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.

Example 2:
Input: 
l1 = [0] 
l2 = [0]
Output: [0]

Example 3:
Input: 
l1 = [9,9,9,9,9,9,9]
l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]

Example 4:
Input:
l1 = [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1]
l2 = [5,6,4]
Output:[6,6,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1]

Constraints:
The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.
*/
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class Solution
{
    public ListNode head;
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode tempHead = new ListNode();
        ListNode current = tempHead;
        int carry = 0;
        int l1Value;
        int l2Value;
        while (l1 != null || l2 != null || carry > 0)
        {
            if (l1 != null) { l1Value = l1.val; l1 = l1.next; } else l1Value = 0;
            if (l2 != null) { l2Value = l2.val; l2 = l2.next; } else l2Value = 0;
            int sum = l1Value + l2Value + carry;
            int rem = sum % 10;
            carry = sum / 10;
            ListNode toAdd = new ListNode(rem, null);
            current.next = toAdd;
            current = current.next;

        }
        return tempHead.next;

    }
    public void PrintList(ListNode node)
    {
        while (node != null)
        {
            Console.Write(node.val + "->");
            node = node.next;
        }
    }
    public ListNode AddFirst(int data)
    {
        ListNode toAdd = new ListNode(data, head);
        head = toAdd;
        return head;
    }
}