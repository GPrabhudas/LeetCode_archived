public class Solution {
    private void MinHeapify(int [] heap,int i,int size)
    {
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        int largest = i;
        
        if(left < size && heap[left] <= heap[largest]){
            largest = left;
        }
        
        if(right < size && heap[right] <= heap[largest]){
            largest = right;
        }
        
        if(largest != i)
        {
            int temp = heap[largest];
            heap[largest] = heap[i];
            heap[i] = temp;
            MinHeapify(heap,largest,size);
        }
    }
    public int FindKthLargest(int[] nums, int k) {
       if(nums.Length > 0)
       {
            int largest = 0;
        int [] heap = new int[k];
        int i,j;
        for(i=0;i<k;i++){
            heap[i] = nums[i];
        }
        j=k/2-1;
        for(;j>=0;j--){
            MinHeapify(heap,j,k);
        }
        for(i=k;i<nums.Length;i++)
        {
            if(nums[i] > heap[0])
            {
                heap[0] = nums[i];
                MinHeapify(heap,0,k);
            }
        }
        largest = heap[0];
        return largest;
       }
        return -1;
    }
}
