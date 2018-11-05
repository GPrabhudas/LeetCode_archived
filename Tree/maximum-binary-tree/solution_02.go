package main

import (
	"fmt"
	"math"
)

// TreeNode ...
// tree type exported from tree package
type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}
type keyValue struct {
	index int
	value int
}

func main() {
	arr := []int{1, 9, 4, 6, 8, 7, 11, 10}
	h := int(math.Log2(float64(len(arr)))) + 1
	stsize := 2*int((math.Pow(2, float64(h)))) - 1
	st := make([]keyValue, stsize)
	constructSegmentTree(arr, st, 0, len(arr)-1, 0)
	root := constructMaximumBinaryTree(arr, st)
	inorder(root)
	fmt.Println()
}

func max(a, b keyValue) keyValue {
	if a.index == -1 {
		return b
	}
	if b.index == -1 {
		return a
	}

	if a.value > b.value {
		return a
	}
	return b
}

func constructSegmentTree(arr []int, st []keyValue, ss, se, si int) keyValue {
	if ss == se {
		st[si] = keyValue{index: ss, value: arr[ss]}
		return st[si]
	}
	mid := ss + (se-ss)/2
	st[si] = max(constructSegmentTree(arr, st, ss, mid, 2*si+1), constructSegmentTree(arr, st, mid+1, se, 2*si+2))
	return st[si]
}

func getMaxIndex(st []keyValue, ss, se, qs, qe, si int) keyValue {
	if ss >= qs && se <= qe {
		return st[si]
	}
	if se < qs || ss > qe {
		return keyValue{index: -1, value: -1}
	}
	mid := ss + (se-ss)/2
	return max(getMaxIndex(st, ss, mid, qs, qe, 2*si+1), getMaxIndex(st, mid+1, se, qs, qe, 2*si+2))
}

func constructMaximumBinaryTree(nums []int, st []keyValue) *TreeNode {
	return construct(nums, st, 0, len(nums))
}

func inorder(root *TreeNode) {
	if root != nil {
		inorder(root.Left)
		fmt.Printf("%d ", root.Val)
		inorder(root.Right)
	}
}

func construct(nums []int, st []keyValue, l, r int) *TreeNode {
	if l == r {
		return nil
	}
	maxNode := getMaxIndex(st, 0, len(nums)-1, l, r-1, 0)
	maxI := maxNode.index
	root := &TreeNode{Val: nums[maxI], Left: nil, Right: nil}
	root.Left = construct(nums, st, l, maxI)
	root.Right = construct(nums, st, maxI+1, r)
	return root
}
