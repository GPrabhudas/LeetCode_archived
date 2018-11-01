func rob(nums []int) int {
    n:=len(nums)
    if n == 0 {
        return 0
    }
    
    if n == 1 {
        return nums[0]
    }
    
    incl,excl := nums[0],0
    for i:=1;i<n;i++ {
        newexcl := max(incl,excl)
        incl = excl + nums[i]
        excl = newexcl
    }
    max1 := excl
    incl = nums[n-1]
    excl = 0
    for i:=n-2;i>=0;i-- {
        newexcl := max(incl,excl)
        incl = excl + nums[i]
        excl = newexcl
    }
    max2 := excl
    return max(max1,max2)
}
func max(a,b int) int {
    if a > b {
        return a
    }
    return b
}
