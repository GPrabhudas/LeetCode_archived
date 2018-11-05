// // time complexity o(n*n)
package main

// import (
// 	"fmt"
// )

// func main() {
// 	root := constructMaximumBinaryTree([]int{3, 2, 1, 6, 0, 5})
// 	inorder(root)
// 	fmt.Println()
// }

// // TreeNode ...
// // tree type exported from tree package
// type TreeNode struct {
// 	Val   int
// 	Left  *TreeNode
// 	Right *TreeNode
// }

// func constructMaximumBinaryTree(nums []int) *TreeNode {
// 	return construct(nums, 0, len(nums))
// }

// func inorder(root *TreeNode) {
// 	if root != nil {
// 		inorder(root.Left)
// 		fmt.Printf("%d ", root.Val)
// 		inorder(root.Right)
// 	}
// }
// func construct(nums []int, l, r int) *TreeNode {
// 	if l == r {
// 		return nil
// 	}
// 	maxI := getMaxIndex(nums, l, r)
// 	root := &TreeNode{
// 		Val: nums[maxI],
// 	}
// 	root.Left = construct(nums, l, maxI)
// 	root.Right = construct(nums, maxI+1, r)
// 	return root
// }

// func getMaxIndex(nums []int, l, r int) int {
// 	maxI := l
// 	for i := l; i < r; i++ {
// 		if nums[maxI] < nums[i] {
// 			maxI = i
// 		}
// 	}
// 	return maxI
// }
