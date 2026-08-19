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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        int remainder = 0;
        while (l1 != null || l2 != null) {
            int l1Val = (l1 == null) ? 0 : l1.val;
            int l2Val = (l2 == null) ? 0 : l2.val;
            int value = l1Val + l2Val + remainder;
            remainder = 0;

            if (value > 9) {
                value -= 10;
                remainder = 1;
            }

            current.next = new ListNode(value);
            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
            current = current.next;
        }

        if (remainder != 0) {
            current.next = new ListNode(remainder);
        }
        return dummy.next;
    }
}
