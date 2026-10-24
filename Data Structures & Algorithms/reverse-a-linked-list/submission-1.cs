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
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null){
            return head;
        }
        Stack<ListNode> stack = new Stack<ListNode>();
        
        Stack<ListNode> tem = reverse(head,stack);
        ListNode newhead = tem.Pop();
        ListNode cur = newhead;
        while(tem.Count()>0){
            ListNode t = tem.Pop();
            cur.next = t;
            cur = t;
        }
        cur.next = null;
        return newhead;
        
        
    }
    public Stack<ListNode> reverse(ListNode curr, Stack<ListNode> stack){
        if(curr != null){
            stack.Push(curr);
            reverse(curr.next,stack);
        }
        return stack;
       

        


        


    }
    

}
