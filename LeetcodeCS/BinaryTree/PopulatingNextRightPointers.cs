// https://leetcode.com/explore/learn/card/data-structure-tree/133/conclusion/994/

/*  You are given a perfect binary tree where all leaves are on the same level, and every parent has two children. 
 *  Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.
 *  Initially, all next pointers are set to NULL.
 */

using System.Collections.Generic;

namespace LeetcodeCS.BinaryTree
{
    class PopulatingNextRightPointers
    {
        public static Node Connect(Node root) 
        {
            if (root == null)
                return null;

            var queue = new Queue<Node>();
            queue.Enqueue(root);

            int expected_on_level = 1;
            int processed_on_level = 0;

            Node prev_on_level = null;

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                ++processed_on_level;

                if (node.left != null && node.right != null)
                {
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }

                if (prev_on_level != null)
                    prev_on_level.next = node;

                if (processed_on_level == expected_on_level)
                {
                    expected_on_level *= 2;
                    processed_on_level = 0;
                    prev_on_level = null;
                }
                else
                    prev_on_level = node;            
            }

            return root;
        }

        public static void Run()
        {
            var root = new Node(1, new Node(2, new Node(4), new Node(5))
                                 , new Node(3, new Node(6), new Node(7)));

            root = Connect(root);
        }
    }
}
