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
        return IsInRange(root, new int[] { int.MinValue, int.MaxValue });
    }

    private bool IsInRange(TreeNode root, int[] range) {
        if (root == null) {
            return true;
        }

        if (root.left != null && (root.left.val >= root.val || root.left.val <= range[0])) {
            return false;
        }
        if (root.right != null && (root.right.val <= root.val || root.right.val >= range[1])) {
            return false;
        }

        return IsInRange(root.left, new int[] { range[0], root.val }) && 
               IsInRange(root.right, new int[] { root.val, range[1] });
    }
}
