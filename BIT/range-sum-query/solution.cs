public class NumArray {

    int [] arr;
    int [] bit;
    public NumArray(int[] nums) {
        arr = new int [nums.Length];
        bit = new int [nums.Length + 1];
        for(int i=0;i<nums.Length;i++){
            Update(i,nums[i]);
        }
    }
    
    public void Update(int i, int val) {
        int diff = val - arr[i];
        arr[i] = val;
        i = i+1;
        while(i < bit.Length){
            bit[i]+=diff;
            i = i + (i & -i);
        }
    }
    
    public int SumRange(int i, int j) {
        int leftsum = 0;
        while(i>0){
            leftsum+=bit[i];
            i = i - (i & -i);
        }
        int rightsum = 0;
        j+=1;
        while(j>0){
            rightsum+=bit[j];
            j = j - (j &-j);
        }
        return rightsum - leftsum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(i,val);
 * int param_2 = obj.SumRange(i,j);
 */
