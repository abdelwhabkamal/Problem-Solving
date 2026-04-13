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
    public IList<int> RightSideView(TreeNode root) {
        IList<int> ans = new List<int>();
        if(root == null) return ans;  
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while(queue.Count>0){
            int level = queue.Count;
            int val=0;
            for(int i = 0 ; i < level; i++){
                TreeNode curr = queue.Dequeue();
                val = curr.val;
                if(curr.left != null ) queue.Enqueue(curr.left);
                if(curr.right != null ) queue.Enqueue(curr.right);
            }
            ans.Add(val);
             
        }
        return ans;
    }
}