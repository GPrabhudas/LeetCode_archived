public class Solution {
    private int BinarySearch(int []nums,int l,int r,int key){
        if(l<=r){
         int mid = l + ((r-l)>>1);
         if(nums[mid] == key)
            return mid;
         if(key < nums[mid])
             return BinarySearch(nums,l,mid-1,key);
         return BinarySearch(nums,mid+1,r,key);
        }
        return -1;
    }
    private int FindPivot(int []nums,int l,int r){
        if(l<=r){
            int mid = l + ((r-l)>>1);
            if(mid < r && nums[mid] > nums[mid+1])
                return mid;
            if(mid > l && nums[mid-1] > nums[mid])
                return mid-1;
            if(nums[l] >= nums[mid])
                return FindPivot(nums,l,mid-1);
            return FindPivot(nums,mid+1,r);
        }
        return -1;
    }
    public int Search(int[] nums, int target) {
        int pivot = FindPivot(nums,0,nums.Length-1);
        if(pivot == -1)
            return BinarySearch(nums,0,nums.Length-1,target);
        if(nums[pivot] == target)
            return pivot;
        if(nums[0] <= target)
            return BinarySearch(nums,0,pivot-1,target);
        return BinarySearch(nums,pivot+1,nums.Length-1,target);
    }
}
