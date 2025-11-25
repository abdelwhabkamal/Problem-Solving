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
    public bool IsValidBST(TreeNode root) {
        List<long> list = new();
        Inorder(root, list);

        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] <= list[i - 1])
                return false;
        }

        return true;
    }
    private void Inorder(TreeNode root, List<long> list)
    {
        if (root == null) return;
        Inorder(root.left, list);
        list.Add(root.val);
        Inorder(root.right, list);
    }
}
