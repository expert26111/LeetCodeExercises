



IList<int> Postorder(Node root)
{
        IList<int> answers = new List<int>();
        if (root == null) return answers;
        Stack<int> stack = new Stack<int>();
        traverse(root);
        void traverse(Node node)
        {
            stack.Push(node.val);
            if (node.children.Count > 0)
            {
                foreach (Node child in node.children.Select(child => child).Reverse())
                {
                    traverse(child);
                }
            }
        }
        return stack.ToArray().ToList();
}




IList<int> Preorder(Node root)
{
    IList<int> answers = new List<int>();
    if (root == null) return answers;
    Stack<Node> stack = new Stack<Node>();
    stack.Push(root);
    while (stack.Count > 0)
    {
        Node node = stack.Pop();
        answers.Add(node.val);
        foreach (Node child in node.children.Select(child => child).Reverse())
        {
            stack.Push(child);
        }
    }
    return answers;
}


public class Node
{
    public int val;
    public IList<Node> children;

    public Node() { }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, IList<Node> _children)
    {
        val = _val;
        children = _children;
    }
}

