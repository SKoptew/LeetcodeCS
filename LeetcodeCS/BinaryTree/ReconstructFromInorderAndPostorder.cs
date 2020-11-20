

namespace LeetcodeCS.BinaryTree
{
    public class ReconstructFromInorderAndPostorder
    {
        public static TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            var inorder_length = inorder.Length;
            var postorder_length = postorder.Length;

            if (inorder_length != postorder_length)
                return null;

            if (inorder_length == 0 || postorder_length == 0)
                return null;

            return BuildSubtree(ref inorder, ref postorder, 0, postorder_length, 0);
        }

    // idx by inorder array
    // sample from postorder with -offset
    public static TreeNode BuildSubtree(ref int[] inorder, ref int[] postorder, int start, int end, int offset)
    {
        var root_val = postorder[end-1 - offset];
        var root_idx = FindElement(root_val, ref inorder, start, end);

        TreeNode left = null;
        TreeNode right = null;

        if ((root_idx - start) > 0)
            left = BuildSubtree(ref inorder, ref postorder, start, root_idx, offset);


        if ((end - root_idx) > 1)
            right = BuildSubtree(ref inorder, ref postorder, root_idx+1, end, offset+1);

        return new TreeNode(root_val, left, right);
    }

    public static int FindElement(int val, ref int[] array, int start, int end)
    {
        for (int i = start; i < end; ++i)
        {
            if (array[i] == val)
                return i;
        }
        return -1;
    }

        public static void Run()
        {
            //var inorder   = new int[] { 9, 3, 15, 20, 7 };
            //var postorder = new int[] { 9, 15, 7, 20, 3 };

            var inorder   = new int[] { 8, 4, 9, 2, 10, 5, 1, 6, 3, 7 };
            var postorder = new int[] { 8, 9, 4, 10, 5, 2, 6, 7, 3, 1 };

            var result = BuildTree(inorder, postorder);
        }
    }
}
