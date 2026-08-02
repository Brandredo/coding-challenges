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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {

        if(root == null) return null;

        return Dfs(root, p, q);

    }

    private TreeNode Dfs(TreeNode node, TreeNode p, TreeNode q) {

        if(node == null) return null;

        var left = Dfs(node.left, p, q);

        if(node == p || node == q) {
            return node;
        }

        var right = Dfs(node.right, p, q);

        if(left != null && right != null) return node;
        
        // if(node.val == p || node.val == q) {
        //     if(left != null || right != null) return node;
        //     return node;
        // }

        //if((node.val == p || node.val == q))

        return left != null ? left : right;
    }



}
