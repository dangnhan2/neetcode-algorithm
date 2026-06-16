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
    public List<int> RightSideView(TreeNode root) {
        List<int> res = new List<int>();

        if (root == null){
            return res;
        }

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0){
            TreeNode right = null;
            int qLength = q.Count;

            for(int i = 0; i < qLength; i++){
               TreeNode node = q.Dequeue();
               
               right = node;
               
               if (node.left != null){
                q.Enqueue(node.left);
               }

               if (node.right != null){
                q.Enqueue(node.right);
               }               
            }

            if (right != null){
                res.Add(right.val);
            }               
        }          
        return res;
    }    

}
