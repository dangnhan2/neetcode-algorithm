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

        Queue<TreeNode> s1 = new Queue<TreeNode>();
        s1.Enqueue(p);
        s1.Enqueue(q);

        while(s1.Count > 0){
            TreeNode n1 = s1.Dequeue();
            TreeNode n2 = s1.Dequeue();
            
            if (n1 == null && n2 == null){
                continue;
            }           

            if (n1 == null || n2 == null){
                return false;
            }

            if (n1.val != n2.val){
                return false;
            }
           
               s1.Enqueue(n1.left);
               s1.Enqueue(n2.left);
                        
               s1.Enqueue(n1.right);
               s1.Enqueue(n2.right);            

        }

        return true;

    }
}
