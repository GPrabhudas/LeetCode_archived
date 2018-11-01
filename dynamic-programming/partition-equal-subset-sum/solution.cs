public class Solution
    {
        private bool CanPartitionUtil(int[] nums, int n, int sum)
        {
            if (sum == 0)
                return true;
            if (sum != 0 && n <= 0)
                return false;
            if (nums[n - 1] > sum)
                return CanPartitionUtil(nums, n - 1, sum);
            return CanPartitionUtil(nums, n - 1, sum) || CanPartitionUtil(nums, n - 1, sum - nums[n - 1]);

        }
        public bool CanPartition(int[] nums)
        {
            int length = nums.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += nums[i];
            }
            if (sum % 2 != 0)
                return false;
            return CanPartitionUtilDP(nums, length, sum / 2);
        }

        private bool CanPartitionUtilDP(int[] nums, int n, int sum)
        {
            bool[,] dp = new bool[n + 1, sum + 1];
            for (int i = 0; i <= sum; i++)
            {
                dp[0,i] = false;
            }
            for (int i = 0; i <= n; i++)
            {
                dp[i,0] = true;
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= sum; j++)
                {
                    if (nums[i - 1] > j)
                    {
                        dp[i,j] = dp[i - 1,j];
                    }
                    else
                    {
                        dp[i,j] = dp[i - 1,j] || dp[i-1,j - nums[i - 1]];
                    }
                }
            }
            return dp[n,sum];
        }
    }
