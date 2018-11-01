/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    private int GetCount(ListNode head){
        ListNode ptr = head;
        int count = 0;
        while(ptr != null){
            ptr = ptr.next;
            count++;
        }
        return count;
    }
    private ListNode ReverseKGroupUtil(ListNode head,int k,int total){
        
        int count = 0;
        ListNode current = head;
        ListNode next = null;
        ListNode prev = null;
        
        while(current != null && count < k){
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
            count++;
        }
        
        if(next != null && (total-k) >= k){
            head.next = ReverseKGroupUtil(next,k,total-k);
        }else{
            head.next = next;
        }
        return prev;
    }
    public ListNode ReverseKGroup(ListNode head, int k) {
        if(k <= 1)
            return head;
        int total = GetCount(head);
        if(total < k)
            return head;
        return ReverseKGroupUtil(head,k,total);
    }
}
