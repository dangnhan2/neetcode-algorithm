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
        ListNode curr = head;
        int length = GetLength(head);
        int count = length - n;

        if(count == 0){
            return head.next;
        }


        for(int i=0; i< length - 1; i++){
           if(i + 1 == count){
            curr.next = curr.next.next;
            break; 
           }

           curr = curr.next;
        }

        return head;
    }

    public int GetLength(ListNode head){
        int length = 0;
        while(head != null){
            length++;
            head = head.next;
        }
        return length;
    }
}
