using System.Collections.Generic;

namespace LeetcodeCS.BinaryTree
{
    class SolutionLevelOrderTraversal
    {
        public static List<List<int>> LevelOrderTraversal(TreeNode root)
        {
            var result = new List<List<int>>();

            return result;
        }

        public static void Run()
        {
            var input = new TreeNode(3) {left = new TreeNode(9), right = new TreeNode(20) {left = new TreeNode(25), right = new TreeNode(7)}};

            var output = LevelOrderTraversal(input);
        }
    }
}
