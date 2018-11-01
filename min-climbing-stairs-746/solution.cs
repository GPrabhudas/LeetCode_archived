public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        return MinCostUtil(cost,0,cost.Length-1,new int[cost.Length]);
    }
    
    private int Min(int a, int b)
    {
        return  a < b ? a : b;
    }
    
    private int MinCostUtil(int [] cost,int index, int length,int [] dp)
    {
        if(index >= length)
        {
            return 0;
        }
        if(dp[index] == 0)
        {
            dp[index] = cost[index] + MinCostUtil(cost,index+1,length,dp);
        }
        
        if(dp[index + 1] == 0)
        {
            dp[index + 1] = cost[index + 1] + MinCostUtil(cost,index + 2,length,dp);
        }
        return Min(dp[index],dp[index + 1]);
    }
}
