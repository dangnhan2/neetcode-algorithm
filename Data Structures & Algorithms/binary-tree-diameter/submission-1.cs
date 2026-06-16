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
    public int diameter;
    public int DiameterOfBinaryTree(TreeNode root) {
        Dfs(root);
        return diameter;
    }

    public int Dfs(TreeNode root){
        if (root == null){
            return 0;
        }

        int leftHeight =  Dfs(root.left);
        int rightHeight =  Dfs(root.right);
        
        diameter = Math.Max(diameter, leftHeight + rightHeight);

        return 1 + Math.Max(leftHeight, rightHeight);
    }
}
