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
    public int MaxDepth(TreeNode root) {
       return MaxDepthSubTree(root);
    }

    public int MaxDepthSubTree(TreeNode root){

        if (root == null){
            return 0;
        }

        int leftMaxDepth = MaxDepthSubTree(root.left);
        int rightMaxDepth = MaxDepthSubTree(root.right);

        return 1 + Math.Max(leftMaxDepth, rightMaxDepth);

    }
}
