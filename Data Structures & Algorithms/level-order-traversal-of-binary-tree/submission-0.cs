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
    public List<List<int>> LevelOrder(TreeNode root) {
        if (root == null) {
            return new List<List<int>>();
        }

        List<List<int>> traversal = new();
        Queue<TreeNode> nodes = new();
        nodes.Enqueue(root);
        while (nodes.Count > 0) {
            int levelSize = nodes.Count;
            List<int> levelTraversal = new();

            for (int i = 0; i < levelSize; i++) {
                var node = nodes.Dequeue();
                levelTraversal.Add(node.val);

                if (node.left != null) {
                    nodes.Enqueue(node.left);
                }
                if (node.right != null) {
                    nodes.Enqueue(node.right);
                }
            }
            traversal.Add(levelTraversal);
        }
        return traversal;
    }
}
