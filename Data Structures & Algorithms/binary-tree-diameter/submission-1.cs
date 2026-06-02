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
    int diameter = 0;
    public int TreeHeight(TreeNode root)
    {
        if(root == null) return 0;
        int left = TreeHeight(root.left);
        int right = TreeHeight(root.right);

        diameter = Math.Max(diameter, left + right);
        return 1 + Math.Max(left, right);
    }
    public int DiameterOfBinaryTree(TreeNode root) {
        TreeHeight(root);
        return diameter;
    }
}
