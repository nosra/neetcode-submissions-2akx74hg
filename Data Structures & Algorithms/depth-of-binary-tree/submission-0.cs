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
    int maxDepth = 0;
    int curDepth = 0;
    public void MaxDepthHelper(TreeNode root, int depth)
    {
        if(root == null)
            return;
        maxDepth = Math.Max(maxDepth, depth);
        if(root.left != null)
            MaxDepthHelper(root.left, depth + 1);
        if(root.right != null);
            MaxDepthHelper(root.right, depth + 1);
    }
    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;
        MaxDepthHelper(root, 0);
        return maxDepth + 1;
    }
}
