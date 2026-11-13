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
    public bool IsValidBST(TreeNode root) {
        return IsInRange(root, int.MinValue, int.MaxValue);
    }

    private bool IsInRange(TreeNode root, int min, int max) {
        if (root == null) {
            return true;
        }

        // don't even need to evaluate children now. We only need to know whether the current
        // root is in range
        if (root.val <= min || root.val >= max) {
            return false;
        }

        return IsInRange(root.left, min, root.val) && 
               IsInRange(root.right, root.val, max);
    }
}
