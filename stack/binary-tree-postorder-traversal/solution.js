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
    this.push = function(val)
    {
        arr.push(val);
    }
    this.pop = function()
    {
        return arr.pop();
    }
    this.empty = function()
    {
        return arr.length == 0;
    }
}

var postorderTraversal = function(root) {
    var ans = [];
    var stack1 = new Stack();    
    var stack2 = new Stack();
    if(root){
        stack1.push(root);
        while(!stack1.empty()){
            var curr = stack1.pop();
            stack2.push(curr);
            if(curr.left){
                stack1.push(curr.left);
            }
            if(curr.right){
                stack1.push(curr.right);
            }
        }
        while(!stack2.empty()){
            ans.push(stack2.pop().val);
        }
    }
    return ans;
};
