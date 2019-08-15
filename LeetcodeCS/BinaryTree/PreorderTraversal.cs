using System.Collections.Generic;

namespace LeetcodeCS.BinaryTree
{
    public class SolutionPreorderTraversal
    {
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            var res = new List<int>();

            if (root == null)
                return res;

            var stack = new Stack<TreeNode>();

            stack.Push(root);

            while (stack.Count > 0)
            {
                var r = stack.Pop();
                res.Add(r.val);

                if (r.right != null)
                    stack.Push(r.right);

                if (r.left != null)
                    stack.Push(r.left);
            }

            return res;
        }

        public static void Run()
        {
            var input = new TreeNode(1) {right = new TreeNode(2) {left = new TreeNode(3)}};

            var output = PreorderTraversal(input);
        }
    }
}