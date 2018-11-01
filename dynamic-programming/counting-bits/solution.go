var dp map[int]int

func countBitsUtil(n int) int {
	count := 0
	for n != 0 {
		value,ok := dp[n]
		if ok == true {
			count += value
			n = 0
			break
		}
		count++
		n &= n-1
	}
	return count
}

func countBits(n int) []int {
	dp = make(map[int]int)
	ans := make([]int,n+1)
	for i:=0;i<=n;i++ {
		ans[i] = countBitsUtil(i)
		dp[i] = ans[i]
	}
	return ans
}
