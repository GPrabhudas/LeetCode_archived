func permute(nums []int) [][]int {
    n := len(nums)
    totalPermutations := factorial(n)
    arr := make([][]int,totalPermutations)
    for i:=0;i<totalPermutations;i++ {
		arr[i] = make([]int,n)
	}
    count :=0
    permutations(nums,0,n-1,arr,&count)
    return arr
}

func factorial(n int) int{
	if n <= 1 {
		return 1
	}
	return n * factorial(n-1)
}
func permutations(str []int,l,r int,arr [][]int,count *int){
	if l == r {
		copy(arr[*count],str)
		*count++
	} else {
		for i:=l;i<=r;i++ {
			swap(str,l,i)
			permutations(str,l+1,r,arr,count)
			swap(str,l,i)
		}
	}
}
func swap(str []int,l,r int) {
	temp := str[l]
	str[l] = str[r]
	str[r] = temp
}
