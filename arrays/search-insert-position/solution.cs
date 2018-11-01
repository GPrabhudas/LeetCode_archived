public class Solution {
    public int SearchInsertUtil(int [] arr,int l,int r,int key){
        if(l<=r){
            if(key > arr[r])
                return r+1;
            if(key < arr[l])
                return l;
         int mid = l + ((r-l)>>1);
         if(key == arr[mid])
             return mid;
         else if(key < arr[mid])
             return SearchInsertUtil(arr,l,mid-1,key);
         else
            return SearchInsertUtil(arr,mid+1,r,key);    
        }
        return -1;
    }
    public int SearchInsert(int[] nums, int target) {
        return SearchInsertUtil(nums,0,nums.Length-1,target);
    }
}
