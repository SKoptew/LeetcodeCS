using System.Collections.Generic;

namespace LeetcodeCS.BinaryTree
{
    class LowestCommonAncestor
    {
        public static TreeNode FindLCA(TreeNode root, TreeNode p, TreeNode q)
        {
            var trace0 = GetTrace(root, p);
            var trace1 = GetTrace(root, q);

            while (trace0.Count > trace1.Count)
                trace0.Pop();

            while (trace1.Count > trace0.Count)
                trace1.Pop();

            while (trace0.Count > 0)
            {
                var node0 = trace0.Pop();
                var node1 = trace1.Pop();

                if (node0 == node1)
                    return node0;
            }

            return null;
        }

        public static Stack<TreeNode> GetTrace(TreeNode root, TreeNode target)
        {
            var stack = new Stack<TreeNode>();
            var trace = new Stack<TreeNode>();

            stack.Push(root);

            while (stack.Count != 0)
            {
                var node = stack.Pop();

                if (node == target)
                {
                    while (trace.Count > 0 && !(trace.Peek().left == node || trace.Peek().right == node))
                        trace.Pop();
                    trace.Push(node);

                    return trace;
                }

                if (node.left != null || node.right != null)
                {
                    while (trace.Count > 0 && !(trace.Peek().left == node || trace.Peek().right == node))
                        trace.Pop();
                    trace.Push(node);

                    if (node.right != null)
                        stack.Push(node.right);

                    if (node.left != null)
                        stack.Push(node.left);
                }
            }

            return trace;
        }

        public static void Run()
        {
            //var n0 = new TreeNode(4);
            //var n1 = new TreeNode(9);
            //
            //var root = new TreeNode(1) { left  = new TreeNode(2, n0, new TreeNode(5, new TreeNode(8), n1)),
            //                             right = new TreeNode(3, new TreeNode(6), new TreeNode(7))};

            var n0 = new TreeNode(5, new TreeNode(6), new TreeNode(2, new TreeNode(7), new TreeNode(4)));
            var n1 = new TreeNode(1, new TreeNode(0), new TreeNode(8));

            var root = new TreeNode(3) { left = n0, right = n1 };

            var lca = FindLCA(root, n0, n1);
        }
    }
}
