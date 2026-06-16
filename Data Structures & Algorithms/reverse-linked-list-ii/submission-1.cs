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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        ListNode dummy = new ListNode(0,head);
        ListNode leftPrev = dummy, cur = head;
        
        for(int i =0; i<left - 1; i++){
            leftPrev = cur;
            cur = cur.next;
        }
        
        // ListNode start = cur;
        ListNode prev = null;
        for(int i = 0; i < right - left + 1; i++){
            ListNode next = cur.next;
            cur.next = prev;
            prev = cur;
            cur = next;
        }

        leftPrev.next.next = cur;
        leftPrev.next = prev;
        // leftPrev.next = prev;
        // start.next = cur;

        return dummy.next;
    }

    
}