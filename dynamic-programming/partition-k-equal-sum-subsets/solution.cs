public class Solution {
    public bool CanPartitionKSubsets(int[] nums, int k) {
        int sum = 0;
        for(int i=0;i<nums.Length;i++)
        {
            sum+=nums[i];
        }
        if(k<=0 || (sum % k) != 0)
            return false;
        bool [] visited = new bool[nums.Length];
        return CanPartition(nums,visited,0,k,0,0,sum/k);
    }
    public bool CanPartition(int [] nums,bool [] visited,int start_index,int k,int current_sum,int current_num,int target)
    {
        if(k==1)
            return true;
        if(current_sum == target && current_num > 0) 
            return CanPartition(nums,visited,0,k-1,0,0,target);
        for(int i=start_index;i<nums.Length;i++)
        {
            if(!visited[i])
            {
                visited[i] = true;
                if(CanPartition(nums,visited,i+1,k,current_sum+nums[i],current_num++,target))
                    return true;
                visited[i] = false;
            }
        }
        return false;
    }
}
