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
    static bool RightCheck(TreeNode right, int val){
        if (right == null) return true;
        if(right.val <= val) return false;
        return RightCheck(right.left, val) && RightCheck(right.right, val);
    }

    static bool LeftCheck(TreeNode left, int val){
        if (left == null) return true;
        if(left.val >= val) return false;
        return LeftCheck(left.left, val) && LeftCheck(left.right, val);
    }

    public bool IsValidBST(TreeNode root) {        
       if (root == null) return true;     

       if (!LeftCheck(root.left, root.val)) return false;
       if (!RightCheck(root.right, root.val)) return false;

     return IsValidBST(root.left) && IsValidBST(root.right);
    }
}
