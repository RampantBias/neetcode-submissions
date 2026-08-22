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
    public int DiameterOfBinaryTree(TreeNode root) {
        int diameter = 0;
        DFS(root, ref diameter);
        return diameter;
    }

    private int DFS(TreeNode root, ref int diameter) {
        if (root == null) {
            return 0;
        }

        int left = DFS(root.left, ref diameter);
        int right = DFS(root.right, ref diameter);
        diameter = Math.Max(diameter, left + right);
        return 1 + Math.Max(left, right);
    }
}
