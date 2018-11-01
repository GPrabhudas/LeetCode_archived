/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    static ListNode head = null;
    static ListNode last = null;
    long infinity = long.MaxValue;
    
   public class HeapNode{
        public  long val;
        public ListNode next;
        public HeapNode(long value,ListNode nextNode){
            val = value;
            next = nextNode;
        }
    }
    private static void Insert(int value)
    {
        if(head == null)
        {
            head = new ListNode(value);
            last = head;
            return;
        }
        last.next = new ListNode(value);
        last = last.next;
    }
    public static void MinHeapify(HeapNode [] heap, int i,int size)
    {
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        int smallest = i;
        if(left < size && heap[left].val <= heap[smallest].val)
        {
            smallest = left;
        }
        if(right < size && heap[right].val <= heap[smallest].val)
        {
            smallest = right;
        }
        if(smallest != i)
        {
            HeapNode  temp = heap[i];
            heap[i] = heap[smallest];
            heap[smallest] = temp;
            
            MinHeapify(heap,smallest,size);
        }
    }
    public ListNode MergeKLists(ListNode[] lists) {
        head = null;
        last = null;
        if(lists.Length != 0)
        {
            HeapNode [] heap = new HeapNode[lists.Length];
            int j = 0;
            int k = 0;
            for(;j<lists.Length;j++){
                if(lists[j] != null){
                    heap[k++] = new HeapNode((long)lists[j].val,lists[j].next);        
                }
            }
            if(k > 0)
            {
            int i= k/2  - 1;
            for(;i>=0;i--){
                MinHeapify(heap,i,k);
            }
           while(heap[0].val != infinity)
            {
                HeapNode minNode = heap[0];
                if(minNode.next != null)
                {
                    heap[0] = new HeapNode(minNode.next.val,minNode.next.next);
                }else{
                    heap[0] = new HeapNode(infinity,null);
                }
                Insert((int)minNode.val);
                MinHeapify(heap,0,k);
            }
            }
        }
        return head;
    }
}
