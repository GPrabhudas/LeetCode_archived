public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Dictionary<string,bool> hash = new Dictionary<string,bool>();
        IList<IList<int>> result = new List<IList<int>>();
        string key = "{0}{1}{2}";
        Array.Sort(nums);
        int length = nums.Length-2;
        int length1 = nums.Length;
        int prev = int.MinValue;
        for(int i=0;i<length;i++){
            if(prev == nums[i])
                continue;
            int l = i+1;
            int r = length1-1;
            int x = nums[i];
            while(l<r){
                int sum = x + nums[l] + nums[r];
                if(sum < 0)
                    l++;
                else if(sum > 0)
                    r--;
                else{
                    string dictKey = string.Format(key,x,nums[l],nums[r]);
                    if(!hash.ContainsKey(dictKey)){
                        result.Add(new List<int>{x,nums[l],nums[r]});
                        hash.Add(dictKey,true);
                    }
                    l++;
                    r--;
                }
            }
            prev = nums[i];
        }
        return result;
    }
}
