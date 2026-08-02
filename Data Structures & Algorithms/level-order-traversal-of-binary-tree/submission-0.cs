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
        
        if(root == null) return new List<List<int>>();

        Queue<TreeNode> queue = new Queue<TreeNode>();
        List<List<int>> result = new List<List<int>>();

        queue.Enqueue(root);

        while(queue.Any()) {

            // level count
            int levelCount = queue.Count;
            List<int> levelList = new List<int>();

            for(int i = 0; i < levelCount; i++) {

                TreeNode node = queue.Dequeue();

                // add node value to list
                levelList.Add(node.val);

                // process children
                if(node.left != null) {
                    queue.Enqueue(node.left);
                }

                if(node.right != null) {
                    queue.Enqueue(node.right);
                }

            }

            result.Add(levelList);
        }

        return result;


    }
}
