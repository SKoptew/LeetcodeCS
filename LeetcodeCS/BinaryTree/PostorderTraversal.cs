using System.Collections.Generic;

namespace LeetcodeCS.BinaryTree
{
    public class SolutionPostorderTraversal
    {
        public static IList<int> PostorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            if (root == null)
                return result;

            var stack = new Stack<TreeNode>();
            var curr = root;

            while (true)
            {
                if (curr != null)
                {
                    if (curr.left != null)
                    {
                        if (curr.right != null)
                            stack.Push(curr.right);
                        stack.Push(curr);
                        curr = curr.left;
                    }
                    else
                    {
                        if (curr.right != null)
                        {
                            stack.Push(curr);
                            curr = curr.right;
                        }
                        else
                        {
                            result.Add(curr.val);
                            curr = null;
                        }
                    }
                }
                else
                {
                    if (stack.Count == 0)
                        break;

                    curr = stack.Pop();

                    if (curr.right != null && stack.Count > 0 && curr.right == stack.Peek())
                    {
                        var r = stack.Pop();
                        stack.Push(curr);
                        curr = curr.right;
                    }
                    else
                    {
                        result.Add(curr.val);
                        curr = null;
                    }
                }
            }


            return result;
        }

        public static void Run()
        {
            //var input = new TreeNode(1)
            //{
            //    right = new TreeNode(3),
            //    left = new TreeNode(2) { left = new TreeNode(4), right = new TreeNode(5)}
            //};

            var input = new TreeNode(1) {right = new TreeNode(2) {left = new TreeNode(3)}};

            var output = PostorderTraversal(input);
        }
    }
}