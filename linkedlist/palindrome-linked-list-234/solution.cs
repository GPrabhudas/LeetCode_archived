/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        Stack<int> stack = new Stack<int>();
        ListNode temp = head;
        while(temp != null)
        {
            stack.Push(temp.val);
            temp = temp.next;
        }
        while(head != null && stack.Count() > 0)
        {
            int top = stack.Pop();
            if(top != head.val)
                return false;
            head = head.next;
        }
        return true;
    }
}
