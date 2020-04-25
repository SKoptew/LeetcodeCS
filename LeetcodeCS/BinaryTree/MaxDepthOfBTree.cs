using System;

namespace LeetcodeCS.BinaryTree
{
    public class MaxDepthOfBTree
    {
        public static int MaxDepth(TreeNode root)
        {
            int maxDepth = 0;
            TraverseMaxDepth(root, 1, ref maxDepth);
            return maxDepth;
        }

        public static void TraverseMaxDepth(TreeNode leaf, int depth, ref int maxDepth)
        {
            if (leaf == null)
                return;

            if (depth > maxDepth)
                maxDepth = depth;

            TraverseMaxDepth(leaf.left,  depth + 1, ref maxDepth);
            TraverseMaxDepth(leaf.right, depth + 1, ref maxDepth);
        }
        
        public static void Run()
        {
            var input = new TreeNode(1)
            {
                left = new TreeNode(10),
                right = new TreeNode(20) {left = new TreeNode(21)}
            };

            var output = MaxDepth(input);
            Console.Write(output);
        }
    }
}