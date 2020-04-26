using System;

namespace LeetcodeCS.BinaryTree
{
    public class PathSum
    {
        public static bool HasPathSum(TreeNode root, int sum)
        {
            return TraversePathSum(root, 0, sum);
        }

        private static bool TraversePathSum(TreeNode node, int accSum, int targetSum)
        {
            if (node == null)
                return false;

            accSum += node.val;

            if (node.left != null || node.right != null)
            {
                return TraversePathSum(node.left,  accSum, targetSum) ||
                       TraversePathSum(node.right, accSum, targetSum);
            }
            
            return accSum == targetSum;
        }

        public static void Run()
        {
            // var root = new TreeNode(5)
            // {
            //     left = new TreeNode(4)
            //     {
            //         left = new TreeNode(11)
            //         {
            //             left = new TreeNode(7),
            //             right = new TreeNode(2)
            //         }
            //     },
            //     right = new TreeNode(8)
            //     {
            //         left = new TreeNode(13),
            //         right = new TreeNode(4)
            //         {
            //             right = new TreeNode(1)
            //         }
            //     }
            // };
            //
            // var result = HasPathSum(root, 22);

            var root = new TreeNode(1) {left = new TreeNode(2)};
            var result = HasPathSum(root, 1);
            
            Console.Write(result);
        }
    }
}