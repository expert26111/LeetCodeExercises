
TreeNode node1 = new TreeNode(1);
TreeNode node2 = new TreeNode(2);
TreeNode node3 = new TreeNode(3);
TreeNode node4 = new TreeNode(4);
TreeNode node5 = new TreeNode(5);
TreeNode node6 = new TreeNode(6);
TreeNode node7 = new TreeNode(7);
TreeNode node8 = new TreeNode(8);
TreeNode node9 = new TreeNode(9);

node5.left = node3;
node5.right = node6;
node6.right = node8;
node8.right = node9;
node8.left = node7;
node3.right = node4;
node3.left = node2;
node2.left = node1;

IncreasingBST(node5);
TreeNode IncreasingBST(TreeNode root)
{
    if (root == null) { return null; }
    Stack<int> stack = new Stack<int>();
    travers(root);
    void travers(TreeNode node)
    {
        if (node == null) {  return; }
        travers(node.right); 
        stack.Push(node.val);
        travers(node.left);
    
    }

    TreeNode first = new TreeNode(stack.Pop(),null,null);
    TreeNode head = first;
    while(stack.Count > 0)
    {
        first.right = new TreeNode(stack.Pop(), null,null);
        first = first.right;
    }
    return head;

    //TreeNode? head;
    //head = stack.Pop();
    //TreeNode first = head;
    //while(stack.Count > 0) 
    //{
    //   first.right = stack.Pop();
    //  // first.left = null;
    //   first = first.right;
    //}
    //return head;
}




public class TreeNode
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