public class Solution {
    public int ReversePairs(int[] nums) {
        return  MergeSort(nums,0,nums.Length-1);
    }
    public static int MergeSort(int [] nums,int l,int r){
        int ans = 0;
        if(l<r){
            int mid = l + ((r-l) >> 1);
            ans += MergeSort(nums,l,mid);
            ans += MergeSort(nums,mid+1,r);
            ans += Merge(nums,l,mid,r);
        }
        return ans;
    }
    public static int Merge(int [] nums,int l,int mid,int r){
        int i,j,k,p;
        int [] merge = new int [r- l + 1 ];
        i = l;
        j = mid + 1;
        k = 0;
        p = mid + 1;
        int ans = 0;
        while(i<=mid){
            while(p<=r){
                long mul = Convert.ToInt64(2) * Convert.ToInt64(nums[p]);
                //Console.WriteLine(mul);
                if(nums[i] > mul){
                    p++;
                }else{
                    break;
                }
            }
            ans += p - (mid + 1);
            while(j<=r && nums[i] >= nums[j]) merge[k++] = nums[j++];
            merge[k++] = nums[i++];
        }
        while(j<=r){
            merge[k++] = nums[j++];
        }
        for(i=0;i<merge.Length;i++){
            nums[l+i] = merge[i];
        }
        return ans;
    }
    
}
