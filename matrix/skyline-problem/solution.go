package main

import (
	"fmt"
)

func main() {
	grid := [][]int{{3, 0, 8, 4}, {2, 4, 5, 7}, {9, 2, 6, 3}, {0, 3, 1, 0}}
	ans := maxIncreaseKeepingSkyline(grid)
	fmt.Println("max sum :", ans)
}
func max(a, b int) int {
	if a > b {
		return a
	}
	return b
}

func min(a, b int) int {
	if a < b {
		return a
	}
	return b
}

func maxIncreaseKeepingSkyline(grid [][]int) int {
	sum := 0
	row := len(grid)
	col := len(grid[0])
	leftright := make([]int, row)
	topbottom := make([]int, col)
	for i := 0; i < col; i++ {
		m := -1
		for j := 0; j < row; j++ {
			m = max(m, grid[j][i])
		}
		topbottom[i] = m
	}
	for i := 0; i < row; i++ {
		m := -1
		for j := 0; j < col; j++ {
			m = max(m, grid[i][j])
		}
		leftright[i] = m
	}
	for i := 0; i < col; i++ {
		for j := 0; j < row; j++ {
			m := min(leftright[j], topbottom[i])
			if m > grid[j][i] {
				sum += (m - grid[j][i])
			}
		}
	}
	return sum
}
