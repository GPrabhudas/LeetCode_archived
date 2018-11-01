/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        if(head == null)
            return head;
        Queue<int> q = new Queue<int>();
        while(head != null)
        {
            if(head.val != val)
                q.Enqueue(head.val);
            head = head.next;
        }
        ListNode ptr;
        if(q.Count() > 0)
        {
            head = new ListNode(q.Dequeue());
        }
        ptr = head;
        while(q.Count() > 0)
        {
            ptr.next = new ListNode(q.Dequeue());
            ptr = ptr.next;
        }
        return head;
    }
}
