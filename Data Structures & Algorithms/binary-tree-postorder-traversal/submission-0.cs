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
    public List<int> PostorderTraversal(TreeNode root) {
        List<int> res = new List<int>();

        Traversal(root, res);
        return res;
    }

    public void Traversal(TreeNode node, List<int> res){
        if(node == null){
            return;
        }

        Traversal(node.left, res);
        Traversal(node.right, res);
        res.Add(node.val);
    }
}