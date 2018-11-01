/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode ptr;
        int count1 = 0;
        int count2 = 0;
        int diff;
        ptr = headA;
        while(ptr != null)
        {
            count1++;
            ptr = ptr.next;
        }
        ptr = headB;
        while(ptr != null)
        {
            count2++;
            ptr = ptr.next;
        }
        diff = Math.Abs(count1-count2);
        ListNode temp1,temp2;
        temp1 = headA;
        temp2 = headB;
        if(count1 > count2)
        {
            while(diff > 0)
            {
                temp1 = temp1.next;
                diff--;
            }
        }else
        {
            while(diff > 0)
            {
                temp2 = temp2.next;
                diff--;
            }
        }
        while(temp1 != null && temp2 != null)
        {
            if(temp1 == temp2)
                return temp1;
            temp1 = temp1.next;
            temp2 = temp2.next;
        }
        return null;
    }
}
