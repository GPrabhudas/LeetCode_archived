package main

import (
	"fmt"
)
func main(){
	s := convert("PAYPALISHIRING",1)
	fmt.Println(s)
}
func convert(s string, numRows int) string {
    if numRows > 1 && numRows < len(s){
		arr := make([][]byte,numRows)
		for i:=0;i<numRows;i++ {
			arr[i] = make([]byte,0)
		}
		up,down := false,true
		direction := down
		i:=0
		count :=0
		length := len(s)
		for count < length {
			arr[i] = append(arr[i],s[count])
			count = count + 1
			if i == 0 {
				direction = down
			} else if i == numRows -1 {
				direction = up
			}

			if direction == down {
				i = i + 1
			} else {
				i = i - 1
			}
		}
		ans := make([]byte,0)
		for i=0;i<numRows;i++ {
			ans = append(ans,arr[i]...)
		}
		return string(ans)
	}
	return s
}