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
    bool balanced=true;
    public bool IsBalanced(TreeNode root) {
        dfs(root);
        return balanced;
    }
    private int dfs(TreeNode root){
        if(root ==null) return 0;
        int leftDepth = dfs(root.left);
        int rightDepth = dfs(root.right);
        if(Math.Abs(rightDepth-leftDepth)>1) balanced=false;
        return 1 + Math.Max(leftDepth, rightDepth);
    }
}