package main

import (
	"fmt"
)

func main() {
	fmt.Println(removeKdigits("10424545342340423904", 7))
}
func removeKdigits(str string, k int) string {
	arr := make([]byte, 0)
	arr = append(arr, str...)
	n := len(str)
	if k == 0 {
		return str
	}
	if n == k {
		return "0"
	}
	return removedigitsutil(arr, k)
}

func removedigitsutil(arr []byte, k int) string {
	if k == 0 {
		if len(arr) == 0 {
			return "0"
		}
		return string(arr)
	}
	n := len(arr)
	i := 0
	if n <= 1 {
		return "0"
	}
	for i < n-1 && arr[i] <= arr[i+1] {
		i++
	}
	if i == 0 {
		arr = arr[i+1:]
	} else if i == n {
		arr = arr[:i-1]
	} else {
		left := arr[:i]
		right := arr[i+1:]
		newarr := left
		newarr = append(newarr, right...)
		arr = newarr
	}
	j := 0
	n = len(arr)
	for j < n && arr[j] == byte('0') {
		j++
	}
	return removedigitsutil(arr[j:], k-1)
}
