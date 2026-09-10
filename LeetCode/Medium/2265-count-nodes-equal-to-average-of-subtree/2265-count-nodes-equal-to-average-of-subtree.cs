public class Solution {
    int res = 0;

    public int AverageOfSubtree(TreeNode root) {
        if (root == null) return 0;
        n = 0;
        int s = sum(root);
        if (s / n == root.val) res++;
        AverageOfSubtree(root.left);
        AverageOfSubtree(root.right);
        return res;
    }

    int n = 0;
    int sum(TreeNode root) {
        if (root == null) return 0;
        n++;
        return root.val + sum(root.left) + sum(root.right);
    }
}
