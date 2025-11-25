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

    long prev = long.MinValue;

    public bool IsValidBST(TreeNode root) 
    {
        return Inorder(root);
    }

    private bool Inorder(TreeNode root)
    {
        if (root == null) return true;

        if (!Inorder(root.left)) return false;

        if (root.val <= prev) return false;

        prev = root.val;

        return Inorder(root.right);
    }

}
