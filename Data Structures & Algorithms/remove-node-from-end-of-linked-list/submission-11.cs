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
        int len = 0;
        
        ListNode curr = head;
        while(curr != null){
            len++;
            curr = curr.next;
        }
        int node = len - n ;
        if(len==1){
            head = null;
            return head;
        }
        if(len==n){
            head = head.next;
            return head;

        }
        
    

        
        
        int count = 1;
        ListNode temp = head;
        while(count<node){
            temp = temp.next;
            count++;
        }
        if(temp.next != null && temp.next.next != null){
            ListNode t = temp.next.next;
            temp.next.next = null;
            temp.next = t;
            
        }
        else{
           temp.next = null;
        }
        return head;
        
    }
}
