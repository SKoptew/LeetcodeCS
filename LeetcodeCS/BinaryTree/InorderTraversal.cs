using System.Collections.Generic;

namespace LeetcodeCS.BinaryTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x) { val = x; }
    }

    public class SolutionInorderTraversal
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            var res = new List<int>();

            if (root == null)
                return res;

            var curr = root;
            var stack = new Stack<TreeNode>();

            while (true)
            {
                if (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        var top = stack.Pop();
                        res.Add(top.val);

                        curr = top.right;
                    }
                    else
                        break;
                }
            }

            return res;
        }

        public static void Run()
        {
            var input = new TreeNode(1) {right = new TreeNode(2) {left = new TreeNode(3)}};

            var output = InorderTraversal(input);
        }
    }
}