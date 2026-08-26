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
    public bool IsBalanced(TreeNode root) {
        if (root == null)
            return true;

        int maxHeightDifference = 0;
        DFS(root, ref maxHeightDifference);
        return maxHeightDifference != -1 && maxHeightDifference <= 1;
    }

    private int DFS(TreeNode node, ref int maxHeightDifference) {
        if (maxHeightDifference == -1)
            return -1;
        if (node == null)
            return 0;
        
        int left = DFS(node.left, ref maxHeightDifference);
        int right = DFS(node.right, ref maxHeightDifference);

        maxHeightDifference = Math.Max(maxHeightDifference, Math.Abs(right - left));
        return 1 + Math.Max(left, right);
    }
}
