/**
Given a binary tree, find its maximum depth.

The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

Note: A leaf is a node with no children.

Example:

Given binary tree [3,9,20,null,null,15,7],

    3
   / \
  9  20
    /  \
   15   7
return its depth = 3.
Definition for a binary tree node.

Definition for a binary tree node.
public class TreeNode {
public int val;
public TreeNode left;
public TreeNode right;
public TreeNode(int x) { val = x; }
  }
 */
public class Solution {
    private int depth = 1;
    public int MaxDepth(TreeNode root) {
        if (root == null){
            return 0;
        }
        else if(root.left != null && root.right != null){
            //depth = depth + 1;
            return Math.Max(MaxDepth(root.left),MaxDepth(root.right)) + 1;
        }else if (root.right != null && root.left == null){
            //depth = depth + 1;
            return MaxDepth(root.right) + 1;
        }else if ( root.right == null && root.left != null){
            //depth = depth + 1;
            return MaxDepth(root.left) + 1;
        }else{
            return depth;
        }
        
    }
}