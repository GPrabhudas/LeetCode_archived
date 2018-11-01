/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode ptr = head;
        while(ptr != null && ptr.next != null)
        {
            if(ptr.val == ptr.next.val)
            {
                ptr.next = ptr.next.next;
            }
            else
            {
                ptr = ptr.next;        
            }
        }
        return head;
    }
}
