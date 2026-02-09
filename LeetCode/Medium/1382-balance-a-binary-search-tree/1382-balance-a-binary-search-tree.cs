public class Solution {
    public TreeNode BalanceBST(TreeNode root) {
        SortedSet<int> set = new();
        Traverse(root);
        int[] sortedArr = set.ToArray();
        return Balance(0, set.Count - 1);

        void Traverse(TreeNode node) {
            if(node == null) return;
            set.Add(node.val);
            Traverse(node.right);
            Traverse(node.left);
        }

        TreeNode Balance(int i, int j) {
            if (i > j) return null;
            int mid = i + (j - i) / 2;

            return new TreeNode(sortedArr[mid], Balance(i, mid - 1),
                Balance(mid + 1, j));
        }
    }
}