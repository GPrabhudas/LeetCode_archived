public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int length = nums.Length;
        int [] res = new int [2];
        Dictionary<int,int> hash = new Dictionary<int,int>();
        for(int i=0;i<length;i++){
            if(hash.ContainsKey((target-nums[i]))){
                res[0] = hash[target-nums[i]];
                res[1] = i;
                break;
            }else if(!hash.ContainsKey(nums[i])){
                hash.Add(nums[i],i);
            }
        }
        return res;
    }
}
