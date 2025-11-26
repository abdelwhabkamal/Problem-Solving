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
    private int smallest=0;
    private int new_k=0;
    public int KthSmallest(TreeNode root, int k) {
        new_k=k;
        Inorder(root);
        return smallest;
    }
    void Inorder(TreeNode root) {
        if(root==null || new_k==0)return;
        Inorder(root.left);
        new_k--;
        if (new_k==0){
            smallest=root.val;
            return;
        } 
        Inorder(root.right);
    }
}