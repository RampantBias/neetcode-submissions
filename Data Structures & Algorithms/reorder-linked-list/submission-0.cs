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
    public void ReorderList(ListNode head) {
        // Move fast and slow pointer to reach end of list
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null) {
            fast = fast.next.next;
            slow = slow.next;
        }

        // Slow should now be at the last node in the ordered set
        // Fast is now at the last node
        // Reverse the second half of the list
        ListNode secondHalf = slow.next;
        slow.next = null;//cut connection
        
        ListNode current = secondHalf, previous = null;
        while (current != null) {
            ListNode? next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }
        secondHalf = previous;//Set to end of original list, start of new merge

        ListNode firstHalf = head;
        secondHalf = previous;
        while (secondHalf != null) {
            var nextFirst = firstHalf.next;
            var nextSecond = secondHalf.next;
            
            firstHalf.next = secondHalf;
            secondHalf.next = nextFirst;
            
            firstHalf = nextFirst;
            secondHalf = nextSecond;
        }
    }
}
