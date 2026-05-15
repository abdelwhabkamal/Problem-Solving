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
        if(nums.Length <= 0) return null;
        int mid = nums.Length / 2;
        TreeNode tree = new(nums[mid]);
        tree.right = SortedArrayToBST(nums[(mid + 1)..]);
        tree.left = SortedArrayToBST(nums[..mid]);
        return tree;
    }
}