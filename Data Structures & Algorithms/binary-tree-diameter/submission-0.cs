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
    private int diameter = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        Traversal(root);
        return diameter;
    }
    
    public int Traversal(TreeNode node){
        if(node == null){
            return 0;
        }

        int left = Traversal(node.left);
        int right = Traversal(node.right);

        diameter = Math.Max(diameter, left + right);

        return 1 + Math.Max(left,right);
    }
}
