




using System;
using System.Collections.Generic;


Console.WriteLine("Hello, World!");

 bool IsSymmetric(TreeNode root)
{
    if(root!= null)
    {
        return Compare(root.left,root.right);
    }
    else
    {
        return false;
    }
    bool Compare(TreeNode? p, TreeNode? q)
    {
        if (p == null && q == null) { return true; }
        else if (p != null && q == null) { return false; }
        else if (p == null && q != null) { return false; }
        else if (p.val == q.val)
        {
            return Compare(p.left, q.right) &&
            Compare(p.right, q.left);
        }
        else
        {
            return false;
        }
    }
}
bool IsSameTree(TreeNode p, TreeNode q)
{
    // IList<int> listP = InorderTraversal(p);
    // IList<int> listQ = InorderTraversal(q);
    // return  listP.SequenceEqual(listQ);

    if (p == null && q == null)
    {
        return true;
    }
    else if (p == null || q == null)
    {
        return false;
    }
    if (p.val != q.val)
    {
        return false;
    }
    return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);

}


IList<int> InorderTraversal(TreeNode root)
{
    IList<int> list = new List<int>();
    populateList(root);
    void populateList(TreeNode node)
    {
        if (node == null) { return; }
        if (node.left != null) { populateList(node.left); }
        list.Add(node.val);
        if (node.right != null) { populateList(node.right); }
    }
    return list;
}

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