using System;

namespace LeetcodeCS.BinaryTree
{
    public class SymmetricTree
    {
        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true; // dunno why, so it is leetcode correct answer

            return TraverseSymmetric(root.left, root.right);
        }

        private static bool TraverseSymmetric(TreeNode leaf0, TreeNode leaf1)
        {
            if (leaf0 == null && leaf1 == null)
                return true;

            if (leaf0 == null ^ leaf1 == null)
                return false;
            
            if (leaf0.val != leaf1.val)
                return false;

            return TraverseSymmetric(leaf0.left, leaf1.right) && TraverseSymmetric(leaf0.right, leaf1.left);
        }

        public static void Run()
        {
            /*var input = new TreeNode(1)
            {
                left = new TreeNode(2) {right = new TreeNode(3)},
                right = new TreeNode(2) {right = new TreeNode(3)}
            };*/
            
            var input = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(3)
                    {
                        left = new TreeNode(5),
                        right = new TreeNode(6)
                    },
                    right = new TreeNode(4)
                    {
                        left = new TreeNode(7),
                        right = new TreeNode(8)
                    }
                },
                right = new TreeNode(2)
                {
                    left = new TreeNode(4)
                    {
                        left = new TreeNode(8),
                        right = new TreeNode(7)
                    },
                    right = new TreeNode(3)
                    {
                        left = new TreeNode(6),
                        right = new TreeNode(5)
                    }
                }
            };

            var result = IsSymmetric(input);
            Console.Write(result);
        }
    }
}