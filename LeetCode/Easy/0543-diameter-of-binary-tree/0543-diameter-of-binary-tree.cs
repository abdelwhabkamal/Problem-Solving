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
    private int d = 0;

    public int DiameterOfBinaryTree(TreeNode root) {
        maxD(root);
        return d;
    }

    int maxD(TreeNode root){
        if(root == null) return 0;

        int left = maxD(root.left);
        int right = maxD(root.right);

        d = Math.Max(d, left + right);

        return 1 + Math.Max(left, right);
    }
}
