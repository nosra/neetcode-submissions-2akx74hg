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
    bool exists = false;
    public bool SameTree(TreeNode root, TreeNode subRoot)
    {
        if(root == null && subRoot == null) return true;
        if(root == null || subRoot == null) return false;
        if(root.val != subRoot.val) return false;
        return SameTree(root.left, subRoot.left) && SameTree(root.right, subRoot.right);
    }
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root == null || subRoot == null) return exists;
        if(SameTree(root, subRoot) == true) exists = true;
        bool left = IsSubtree(root.left, subRoot);
        bool right = IsSubtree(root.right, subRoot);
        return exists;
    }
}
