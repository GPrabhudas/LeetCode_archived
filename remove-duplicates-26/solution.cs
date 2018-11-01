public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int length = nums.Length;
        if(length == 0 || length == 1)
            return length;
        
        int count = 0;
        length = length - 1;
        for(int i=0;i<length;i++){
            if(nums[i] != nums[i+1]){
                nums[count++] = nums[i];
            }
        }
        nums[count++] = nums[length];
        return count;
    }
}
