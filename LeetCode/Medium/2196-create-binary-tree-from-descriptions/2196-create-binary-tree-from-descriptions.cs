/*
Title: 2196. Create Binary Tree From Descriptions
Solution:
Difficulty: Medium
Approach: Hash Table + HashSet to track children
Tags: Array, Hash Table, Tree, Binary Tree
1) Use a dictionary to map each node value to its TreeNode.
2) Use a HashSet to record all nodes that appear as a child.
3) For each description, retrieve or create parent and child nodes.
4) Attach the child to the parent's left or right based on the isLeft flag.
5) After processing all descriptions, the root is the node that never appeared as a child.

Time Complexity: O(n) where n = number of descriptions
Space Complexity: O(n) for the dictionary and hash set
Tip: The key insight is that the root is the only node that never appears as a child. Build all nodes and edges in one pass, then identify the root by set difference.
Similar Problems: 1008. Construct Binary Search Tree from Preorder Traversal, 105. Construct Binary Tree from Preorder and Inorder Traversal
*/

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
    public TreeNode CreateBinaryTree(int[][] descriptions) {

        Dictionary<int,TreeNode> dict = new Dictionary<int,TreeNode>();     
        TreeNode root = new TreeNode();                                     
        HashSet<int> children = new HashSet<int>();                       

        foreach(int[] arr in descriptions) {
            TreeNode parentNode;
            TreeNode childNode;

            if (!dict.ContainsKey(arr[0])) {                                 
                dict[arr[0]] = new TreeNode(arr[0]);
            }

            parentNode = dict[arr[0]];                                      
            if (!dict.ContainsKey(arr[1])) {                                  
                dict[arr[1]] = new TreeNode(arr[1]);
            }

            childNode = dict[arr[1]];                                       

            if (arr[2] == 1) {
                parentNode.left = childNode;                                
            }
            else {
                parentNode.right = childNode;                               
            }

            children.Add(arr[1]);

        }

        foreach (var kvp in dict) {
            if (!children.Contains(kvp.Key)) {
                return kvp.Value;
            }
        }

        return root;

    }
}