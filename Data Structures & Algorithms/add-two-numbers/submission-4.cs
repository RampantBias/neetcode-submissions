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
        int remainder = 0;
        ListNode result = new ListNode(0);
        ListNode current = result;
        while (l1 != null || l2 != null || remainder != 0) {
            int val1 = l1?.val ?? 0;
            int val2 = l2?.val ?? 0;

            int sum = val1 + val2 + remainder;
            remainder = sum / 10;
            sum = sum % 10;
            current.next = new ListNode(sum);
            
            current = current.next;
            if (l1 != null) {
                l1 = l1.next;
            }
            if (l2 != null) {
                l2 = l2.next;
            }
        }

        while (l1 != null) {
            current.next = new ListNode(l1.val);
            current = current.next;
            l1 = l1.next;
        }
        while (l2 != null) {
            current.next = new ListNode(l2.val);
            current = current.next;
            l2 = l2.next;
        }

        if (remainder > 0) {
            current.next = new ListNode(remainder);
        }

        return result.next;
    }
}
