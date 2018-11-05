package main

import (
	"fmt"
)

// TreeNode ...
// tree type exported from tree package
type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}

func constructSegmentTree(arr, st []int, ss, se, si int) int {
	if ss == se {
		st[si] = ss
		return st[si]
	}
	mid := ss + (se-ss)/2
	left := constructSegmentTree(arr, st, ss, mid, 2*si+1)
	right := constructSegmentTree(arr, st, mid+1, se, 2*si+2)
	st[si] = left
	if arr[right] > arr[left] {
		st[si] = right
	}
	return st[si]
}
func main() {
	arr := []int{3, 2, 1, 6, 0, 5}
	st := make([]int, 2*len(arr)-1)
	constructSegmentTree(arr, st, 0, len(arr)-1, 0)
	root := constructMaximumBinaryTree(arr, st)
	inorder(root)
	fmt.Println()
}

func constructMaximumBinaryTree(nums, st []int) *TreeNode {
	return construct(nums, st, 0, len(nums))
}

func inorder(root *TreeNode) {
	if root != nil {
		inorder(root.Left)
		fmt.Printf("%d ", root.Val)
		inorder(root.Right)
	}
}
func construct(nums, st []int, l, r int) *TreeNode {
	if l == r {
		return nil
	}
	maxI := getMaxIndex(nums, st, 0, len(nums)-1, l, r, 0)
	root := &TreeNode{
		Val: nums[maxI],
	}
	root.Left = construct(nums, st, l, maxI)
	root.Right = construct(nums, st, maxI+1, r)
	return root
}

func getMaxIndex(nums, st []int, ss, se, qs, qe, si int) int {
	if qs <= ss && qe >= se {
		return st[si]
	}
	if qe < ss || qs > se {
		return len(nums)
	}
	mid := ss + (se-ss)/2
	left := getMaxIndex(nums, st, ss, mid, qs, qe, 2*si+1)
	right := getMaxIndex(nums, st, mid+1, se, qs, qe, 2*si+2)
	if left == len(nums) {
		return right
	}
	if right == len(nums) {
		return left
	}

}
