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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> ans = new List<IList<int>>();
        if(root==null) return ans;
        Queue<TreeNode> queue= new();
        queue.Enqueue(root);
        while(queue.Count>0){
            List<int> list = new();
            int level = queue.Count();
            for(int i = 0; i < level; i++){
                TreeNode curr = queue.Dequeue();
                list.Add(curr.val);
                if(curr.left != null) queue.Enqueue(curr.left);
                if(curr.right != null) queue.Enqueue(curr.right);
            }
            ans.Add(list);
            
        }
        return ans;
    }
}