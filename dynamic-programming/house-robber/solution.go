func rob(nums []int) int {
    if len(nums) == 0 {
        return 0
    }
    incl,excl := nums[0],0
    n := len(nums)
    for i := 1;i<n;i++ {
        exclnew := max(incl,excl)
        incl = excl + nums[i]
        excl = exclnew
    }
    if excl > incl {
        return excl
    }
    return incl
}
func max(a,b int) int {
    if a > b {
        return a
    }
    return b
}
