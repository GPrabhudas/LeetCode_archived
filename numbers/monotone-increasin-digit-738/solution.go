package main

import (
	"fmt"
	"strconv"
)

func main() {
	fmt.Println(monotoneIncreasingDigits(332))
}
func monotoneIncreasingDigits(N int) int {
	str := strconv.Itoa(N)
	arr := make([]byte, 0)
	arr = append(arr, str...)
	n := len(str)
	lastIndex := n
	for i := n - 1; i > 0; i-- {
		if arr[i] < arr[i-1] {
			lastIndex = i
			x := int(arr[i-1]) - 1
			arr[i-1] = byte(x)
		}
	}
	for i := lastIndex; i < n; i++ {
		arr[i] = byte('9')
	}
	ans, _ := strconv.Atoi(string(arr))
	return ans
}
