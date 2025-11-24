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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root==null && subRoot==null) return true;
        if(root == null || subRoot == null ) return false;
        if(isSame(root,subRoot))return true;
        return IsSubtree(root.left,subRoot) || IsSubtree(root.right,subRoot);

    }
    bool isSame(TreeNode root1, TreeNode root2){
        if(root1==null && root2==null) return true;
        if(root1==null || root2==null) return false;
        if(root1.val != root2.val)return false;
        return isSame(root1.right,root2.right) && isSame(root1.left,root2.left);
    }
    
}