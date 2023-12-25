


Console.WriteLine("Hello, World!");


 int MaxDepth(TreeNode root)
{
    if(root!=null)
    {
        return Math.Max(1+MaxDepth(root.left), 1+MaxDepth(root.right));
    }
    else
    {
        return 0;
    }
}

 class TreeNode
{
     public int val;
     public TreeNode? left;
     public TreeNode? right;
     public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}