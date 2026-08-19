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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        Stack<Tuple<TreeNode, TreeNode>> stack = new Stack<Tuple<TreeNode, TreeNode>>();
        stack.Push(new Tuple<TreeNode, TreeNode>(p, q));

        while (stack.Count > 0) {
            var current = stack.Pop();
            TreeNode nextP = current.Item1;
            TreeNode nextQ = current.Item2;

            if ((nextP == null && nextQ != null) || (nextP != null && nextQ == null)) {
                return false;
            }
            if (nextP == null && nextQ == null) {
                continue;
            }
            else {
                if (nextP.val == nextQ.val) {
                    stack.Push(new Tuple<TreeNode, TreeNode>(nextP.left, nextQ.left));
                    stack.Push(new Tuple<TreeNode, TreeNode>(nextP.right, nextQ.right));
                } else {
                    return false;
                }
            }
        }
        return true;
    }
}
