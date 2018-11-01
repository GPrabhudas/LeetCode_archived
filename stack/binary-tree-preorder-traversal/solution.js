/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[]}
 */
function Stack()
{
    var arr = [];
    this.push = function(val){
        arr.push(val);
    }
    this.empty = function()
    {
        return arr.length == 0;
    }
    this.pop = function()
    {
        return arr.pop();
    }
}
var preorderTraversal = function(root) {
    var ans = [];
    if(root){
        var stack = new Stack();
        stack.push(root);
        while(!stack.empty()){
            var top = stack.pop();
            ans.push(top.val);
            if(top.right){
                stack.push(top.right);
            }
            if(top.left){
                stack.push(top.left);
            }
        }
    }
    return ans;
};
