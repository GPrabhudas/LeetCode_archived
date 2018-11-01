public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int length = nums.Length;
        int upperLength = length-2;
        int prev = int.MinValue;
        int sum = 0;
        int sol = 0;
        int minDiff = int.MaxValue;
        for(int i=0;i<upperLength;i++){
            if(prev == nums[i])
                continue;
            int l = i+1;
            int r = length - 1;
            while(l < r){
                sum = nums[i] + nums[l] + nums[r];
                if(sum == target){
                    return sum;
                }
                int diff = Math.Abs(target-sum);
                if(diff < minDiff){
                        minDiff = diff;
                        sol = sum;
                }
                if(sum > target){
                    r--;
                }else{
                    l++;
                }
            }
            prev = nums[i];
        }
        return sol;
    }
}
