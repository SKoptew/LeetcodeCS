using System.Collections.Generic;

public class SolutionPostorderTraversal
{
    public class TreeNode 
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public static IList<int> PostorderTraversal(TreeNode root)
    {
        var result = new List<int>();

        if (root == null)
            return result;


        return result;
    }

    public static void Run()
    {
        var input = new TreeNode(1){right = new TreeNode(2){left=new TreeNode(3)}};

        var output = PostorderTraversal(input);
    }
}