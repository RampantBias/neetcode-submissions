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
    public List<int> RightSideView(TreeNode root) {
        List<int> view = new();
        if (root == null) {
            return view;
        }

        Queue<TreeNode> nodes = new();
        nodes.Enqueue(root);
        while (nodes.Count > 0) {
            int count = nodes.Count;
            while (count > 0) {
                var node = nodes.Dequeue();
                if (node.left != null) {
                    nodes.Enqueue(node.left);
                }
                if (node.right != null) {
                    nodes.Enqueue(node.right);
                }

                if (count == 1) {
                    view.Add(node.val);
                }

                count--;
            }
        }
        return view;
    }
}
