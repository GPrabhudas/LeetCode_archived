func findLongestChain(pairs [][]int) int {
    n := len(pairs)
    if n== 0 {
        return 0
    }
    sort.Slice(pairs,func(i,j int) bool {
        return pairs[i][1] < pairs[j][1]
    })
    dp := make([]int,n)
    
    for i:=0;i<n;i++ {
        dp[i] = 1
    }
    for i:=1;i<n;i++ {
        for j:=0;j<i;j++ {
            if pairs[j][1] < pairs[i][0] && dp[i] < dp[j] + 1 {
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
    fmt.Println(pairs)
    return max
}
