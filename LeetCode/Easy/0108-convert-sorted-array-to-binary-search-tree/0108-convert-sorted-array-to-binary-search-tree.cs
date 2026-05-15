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
    public TreeNode SortedArrayToBST(int[] nums) {
        return BST(nums , 0 , nums.Length - 1);
    }
    TreeNode BST(int[] nums, int l, int r){
        if(r < l) return null;
        int mid = l + (r - l) / 2;
        TreeNode tree = new(nums[mid]);
        tree.right = BST(nums , mid + 1, r);
        tree.left = BST(nums, l , mid - 1);
        return tree;
    }
}