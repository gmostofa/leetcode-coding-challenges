namespace DefaultNamespace;

public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root == null) return null;

        // Swap children
        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;

        // Recurse
        InvertTree(root.left);
        InvertTree(root.right);

        return root;
    }
}