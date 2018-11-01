/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode result = null,ptr = null;
        if(l1 == null || l2 == null)
            return (l1 == null) ? l2 : l1;
        while(l1 != null && l2 != null){
            if(l1.val < l2.val){
                if(result == null){
                    result = new ListNode(l1.val);
                    ptr = result;
                }else{
                    ptr.next = new ListNode(l1.val);
                    ptr = ptr.next;
                }
                l1 = l1.next;
            }else{
                if(result == null){
                    result = new ListNode(l2.val);
                    ptr = result;
                }else{
                    ptr.next = new ListNode(l2.val);
                    ptr = ptr.next;
                }
                l2 = l2.next;
            }
        }
        while(l1 != null){
            ptr.next = new ListNode(l1.val);
            ptr = ptr.next;
            l1 = l1.next;
        }
        while(l2 != null){
            ptr.next = new ListNode(l2.val);
            ptr = ptr.next;
            l2 = l2.next;
        }
        return result;
    }
}
