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
    public List<int> InorderTraversal(TreeNode root) {
        List<int> res = new List<int>();      
        Traverse(root, res);
        return res;
    }

    public void Traverse(TreeNode node, List<int> res) {
        if (node == null) return;

        Traverse(node.left, res);
        res.Add(node.val);
        Traverse(node.right, res);
   }

}