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
        ListNode dummy = new ListNode(0, head);
        ListNode first = dummy, last = dummy;

        // Move last up n positions
        for (int i = 0; i < n; i++) {
            last = last.next;
        }

        // Push first and last (like sliding window) until fast.next == null
        while (last != null && last.next != null) {
            first = first.next;
            last = last.next;
        }

        first.next = first?.next?.next;
        return dummy.next;
    }
}
