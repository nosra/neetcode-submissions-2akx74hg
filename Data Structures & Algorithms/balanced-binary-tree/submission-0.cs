/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    bool balanced = true;
    public int IsBalancedHelper(TreeNode root, int curHeight) {
        // post order traversal
        if(root == null)
            return 0;
        
        int left = IsBalancedHelper(root.left, curHeight + 1);
        int right = IsBalancedHelper(root.right, curHeight + 1);

        if(Math.Abs(left - right) > 1){
            balanced = false;
        }
        return 1 + Math.Max(left, right); 
    }
    public bool IsBalanced(TreeNode root) {
        IsBalancedHelper(root, 0);
        return balanced;
    }
}
