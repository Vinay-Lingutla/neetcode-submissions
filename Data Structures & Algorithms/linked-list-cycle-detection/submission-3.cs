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
    public bool HasCycle(ListNode head) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        ListNode curr = head;
        while(curr != null){
            if(dict.TryGetValue(curr.val, out int value)){
                if(curr.next != null){
                    return true;
                }
                else{
                    return false;
                }
            }
            dict[curr.val] = 1;
            curr = curr.next;

        }
        return false;
    }
}
