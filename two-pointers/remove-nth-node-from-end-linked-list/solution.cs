/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    private int GetLength(ListNode head){
        ListNode temp = head;
        int count = 0;
        while(temp != null){
            count++;
            temp = temp.next;
        }
        return count;
    }
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int length = GetLength(head);
        if(n > length)
            n = length;
        int nodeToRemove = length - n + 1;
        if(nodeToRemove == 1){
            ListNode temp1 = head;
            head = head.next;
            temp1.next = null;
            return head;
        }
        int count = 1;
        ListNode  ptr = head;
        while(count < (nodeToRemove - 1)){
            count++;
            ptr = ptr.next;
        }
        ListNode temp = ptr.next;
        ptr.next = temp.next;
        temp.next = null;
        return head;
    }
}


