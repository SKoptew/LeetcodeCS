using System.Collections.Generic;

namespace LeetcodeCS.BinaryTree
{
    class SolutionLevelOrderTraversal
    {
        // List< int[] > - supports interface of IList<IList<int>>, list of arrays

        public static IList<IList<int>> LevelOrderTraversal(TreeNode root)
        {
            var result = new List<IList<int>>();

            var queue = new Queue<TreeNode>();

            if (root != null)
                queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var levelSize = queue.Count;
                var level = new int[levelSize];

                for (int i = 0; i < levelSize; ++i)
                {
                    var node = queue.Dequeue();
                    
                    if (node.left != null)
                        queue.Enqueue(node.left);

                    if (node.right != null)
                        queue.Enqueue(node.right);

                    level[i] = node.val;
                }

                result.Add(level);
            }

            return result;
        }

        public static void Run()
        {
            var input = new TreeNode(3) {left = new TreeNode(9), right = new TreeNode(20) {left = new TreeNode(25), right = new TreeNode(7)}};

            var output = LevelOrderTraversal(input);
        }
    }
}
