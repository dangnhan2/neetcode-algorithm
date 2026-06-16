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
    public TreeNode InvertTree(TreeNode root) {
        return Dfs(root);
    }

    public TreeNode Dfs(TreeNode root){
        
        if (root == null){
            return root;
        }
        
        TreeNode temp = root.right;
        root.right = root.left;
        root.left = temp;

        Dfs(root.left);
        Dfs(root.right);  
        
        return root;
    }
}
