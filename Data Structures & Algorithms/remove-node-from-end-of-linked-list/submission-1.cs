/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode left = head, right = head;
        // move right forward n distance from left
        for (int i = 0; i < n - 1; i++) {
            right = right.next;
        }

        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode previous = dummy;

        while (right.next != null) {
            previous = previous.next;
            left = left.next;
            right = right.next;
        }
        previous.next = left.next;
        return dummy.next;
    }
}
