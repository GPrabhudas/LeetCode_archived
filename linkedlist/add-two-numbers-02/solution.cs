/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode result = null,ptr=null;
        int cary=0,sum=0;
        while(l1 != null && l2 != null){
            sum = l1.val + l2.val + cary;
            cary = sum/10;
            sum = sum % 10;
            if(result == null){
                result = new ListNode(sum);
                ptr = result;
            }else{
                ptr.next = new ListNode(sum);
                ptr = ptr.next;
            }
            l1 = l1.next;
            l2 = l2.next;
        }
        while(l1 != null){
            sum = l1.val + cary;
            cary = sum / 10;
            sum = sum % 10;
            ptr.next = new ListNode(sum);
            ptr = ptr.next;
            l1 = l1.next;
        }
        while(l2 != null){
            sum = l2.val + cary;
            cary = sum / 10;
            sum = sum % 10;
            ptr.next = new ListNode(sum);
            ptr = ptr.next;
            l2 = l2.next;
        }
        if(cary != 0){
            ptr.next = new ListNode(cary);
        }
        return result;
    }
}
