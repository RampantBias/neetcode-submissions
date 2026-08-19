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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode? dummy = new ListNode(0);
        ListNode? current = dummy;
        ListNode? next1 = list1, next2 = list2;
        while (next1 != null && next2 != null) {
            if (next1.val <= next2.val) {
                current.next = next1;
                next1 = next1.next;
            }
            else {
                current.next = next2;
                next2 = next2.next;
            }
            current = current.next;
        }

        if (next1 != null) {
            current.next = next1;
        }
        if (next2 != null) {
            current.next = next2;
        }

        return dummy.next;
    }
}