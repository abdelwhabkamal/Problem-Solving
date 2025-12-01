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
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> res=new List<int>();
        void inorder(TreeNode root){
            if(root == null)return;
            inorder(root.left);
            res.Add(root.val);
            inorder(root.right);
        }    
        inorder(root);
        return res;
    }

}