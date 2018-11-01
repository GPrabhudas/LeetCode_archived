func lengthOfLIS(nums []int) int {
    n := len(nums)
    if n == 0 {
        return 0
    }
    dp := make([]int,n)
    for i:=0;i<n;i++ {
        dp[i] = 1
    }
    for i:=1;i<n;i++ {
        for j:=0;j<i;j++ {
            if nums[j] < nums[i] && dp[i] < dp[j] + 1 {
                dp[i] = dp[j] + 1
            }
        }
    }
    max := dp[0]
    for i:=1;i<n;i++ {
        if max < dp[i] {
            max = dp[i]
        }
    }
    return max
}
