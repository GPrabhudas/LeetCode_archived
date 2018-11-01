public class Solution {
    private int SearchFirst(int []arr,int l,int r,int key){
        if(l<=r){
            int mid = l + ((r-l)>>1);
            if((mid == 0 || key > arr[mid-1]) && arr[mid] == key)
                return mid;
            else if(key > arr[mid])
                return SearchFirst(arr,mid+1,r,key);
            else
                return SearchFirst(arr,l,mid-1,key);
        }
        return -1;
    }
    
    private int SearchLast(int []arr,int l,int r,int key){
        if(l <= r){
            int mid = l + ((r-l)>>1);
            if((mid==arr.Length-1 || key < arr[mid+1]) && arr[mid]==key)
                return mid;
            else if(key < arr[mid])
                return SearchLast(arr,l,mid-1,key);
            else return SearchLast(arr,mid+1,r,key);
        }
        return -1;
    }
    
    public int[] SearchRange(int[] nums, int target) {
        int []res = new int[2];
        res[0] = res[1] = -1;
        res[0] = SearchFirst(nums,0,nums.Length-1,target);
        if(res[0] == -1)
            return res;
        res[1] = SearchLast(nums,0,nums.Length-1,target);
        return res;
    }
}
