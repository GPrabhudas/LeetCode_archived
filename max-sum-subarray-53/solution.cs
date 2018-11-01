public class Solution {
    public int MaxSubArray(int[] nums) {
        bool allNegative = true;
        int max = int.MinValue;
        for(int i=0;i<nums.Length;i++){
            if(nums[i] > 0)
            {
                allNegative = false;
                break;
            }
            if(nums[i] > max)
                max = nums[i];
        }
        if(allNegative == true)
            return max;
        
        int maxSoFar = 0;
        int maxEndingHere = 0;
        for(int i=0;i<nums.Length;i++){
            maxEndingHere+=nums[i];
            if(maxEndingHere < 0){
                maxEndingHere = 0;
            }else if(maxEndingHere > maxSoFar){
                maxSoFar = maxEndingHere;
            }
        }
        return maxSoFar;
    }
}
