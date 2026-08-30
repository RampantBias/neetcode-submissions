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
        if (list1 == null && list2 == null){
            return list1;
        }

        ListNode placeholder = new ListNode(0);
        ListNode current = placeholder;
        ListNode left = list1;
        ListNode right = list2;

        while (left != null && right != null) {
            if (left.val <= right.val) {
                current.next = left;
                left = left.next;
            } else {
                current.next = right;
                right = right.next;
            }
            current = current.next;
        }

        while (left != null) {
            current.next = left;
            left = left.next;
            current = current.next;
        }
        while (right != null) {
            current.next = right;
            right = right.next;
            current = current.next;
        }

        return placeholder.next;
    }
}