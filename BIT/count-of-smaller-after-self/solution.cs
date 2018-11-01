public class Solution {
    public static int BinarySearch(int[] arr,int l,int r,int key){
            if(l<=r){
                int mid = l + (r-l)/2;
                if((mid == 0 || key > arr[mid-1]) && arr[mid] == key){
                    return mid;
                }
                else if(key > arr[mid])
                    return BinarySearch(arr,mid+1,r,key);
                else
                    return BinarySearch(arr,l,mid-1,key);
            }
        return -1;
    }
    
    public IList<int> CountSmaller(int[] nums) {
        int [] temp = new int [nums.Length];
        for(int i=0;i<nums.Length;i++){
            temp[i] = nums[i];    
        }
        Array.Sort(temp);
        IList<int> resList = new List<int>();
        for(int i=0;i<nums.Length;i++){
            nums[i] = BinarySearch(temp,0,temp.Length-1,nums[i]) + 1;    
        }
        int [] bit = new int[nums.Length + 1];
        int [] res = new int [nums.Length];
        for(int i=0;i<bit.Length;i++){
            bit[i] = 0;
        }
        for(int i=nums.Length-1;i>=0;i--){
            res[i] = getSum(bit,nums[i]-1);
            updateBit(bit,nums[i],1);
        }
        for(int i=0;i<res.Length;i++){
            resList.Add(res[i]);
        }
        return resList;
    }
    
    public static int getSum(int [] bit,int index){
        int sum = 0;
        while(index > 0){
            sum += bit[index];
            index = index - (index & -index);
        }
        return sum;
    }
    
    public static void updateBit(int []bit,int index,int val){
        while(index < bit.Length){
            bit[index]+=val;
            index = index + (index & -index);
        }
    }
    
}
