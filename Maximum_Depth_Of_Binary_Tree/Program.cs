




using System;
using System.Collections;
using System.Collections.Generic;
//using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

//Console.WriteLine("Hello, World!");

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

static TreeNode newNode(int data)
{
    TreeNode temp = new TreeNode();

    temp.val = data;

    temp.left = null;
    temp.right = null;

    return temp;
}

TreeNode insert(TreeNode root, int key)
{

    TreeNode newnode = newNode(key);
    TreeNode x = root;
    TreeNode y = null;

    while (x != null)
    {
        y = x;
        if (key < x.val)
            x = x.left;
        else
            x = x.right;
    }
    if (y == null)
        y = newnode;
    else if (key < y.val)
        y.left = newnode;
    else
        y.right = newnode;
    return y;
}




//TreeNode root = null;
//root = insert(root, 1);
//insert(root, 2);
//insert(root, 2);
//insert(root, 3);
//insert(root, 3);




//Console.WriteLine(MinDepth2(root));

//Console.WriteLine(IsBalanced(root));
//[1,2,2,3,3,null,null,4,4]
//c//lass 
//private bool fun;
//public bool Fun   // property
//{
//    get { return fun; }   // get method
//    set { fun = value; }  // set method
//}


//bool bla = false;
//flipBool(bla);
//void flipBool(bool bla)
//{
//      bla = !bla;
//}

//Console.WriteLine("The flipped bla is {0}", bla);



TreeNode  nodeone = new TreeNode(1);
TreeNode  nodetwo = new TreeNode(2);
TreeNode  nodetwo2 = new TreeNode(2);
TreeNode  nodethree = new TreeNode(3);
TreeNode  nodethree2 = new TreeNode(3);
TreeNode  nodefour = new TreeNode(4);
TreeNode  nodefour2 = new TreeNode(4);

nodeone.left = nodetwo;
nodeone.right = nodetwo2;

nodetwo.left = nodethree;

nodethree.left = nodefour;

nodetwo2.right = nodethree2;
nodethree2.right= nodefour2;



//Console.WriteLine(IsBalanced(nodeone));


bool IsBalanced(TreeNode root)
{
    bool check = true;
    helper(root, ref check);
    return check;
    //int truth = helper(root, ref check);
    //if (truth != -1) { return true; } else { return false; }
   // return check;
    int helper(TreeNode node, ref bool check)
    {
        if (node == null)
        {
          //  check = true;
            return -1;
        }
        int L = helper(node.left, ref check);
        int R = helper(node.right, ref  check);
        if ((Math.Abs(L - R) > 1))
        {
           // return -1;
            check = false;         
           // MakeTrue(ref check);
        }
        return Math.Max(L, R) + 1;
    }
   // return check;
}
    //int MaxDepth(TreeNode root)
    //{
    //    if (root != null)
    //    {
    //        return Math.Max(1 + MaxDepth(root.left), 1 + MaxDepth(root.right));
    //    }
    //    else
    //    {
    //        return 0;
    //    }
    //}

    //int getMaxHeightLeft(TreeNode node)
    //{
    //    if (root.left != null)
    //    {
    //        return MaxDepth(node.left);
    //    }
    //    else
    //    {
    //        return 0;
    //    }
    //}

    //int getMaxHeightRight(TreeNode node)
    //{
    //    if (root.right != null)
    //    {
    //        return MaxDepth(node.right);
    //    }
    //    else
    //    {
    //        return 0;
    //    }
    //}




    //if(root== null)
    //{
    //    return true;
    //}
    //int maxL = getMaxHeightLeft(root);
    //int maxR = getMaxHeightRight(root);
    //int result = Math.Abs(maxL - maxR);
    //if(result > 1)
    //{
    //    return true;
    //}
    //else
    //{
    //    return true;
    //}




int MinDepth2(TreeNode root)
{
    if(root == null) { return 0; }
    int height = int.MaxValue;
    int depth = 0;
    if(root.left!=null)
    {
        return helper(root.left);
    }
    else if(root.right!=null) { return helper(root.right); }


    int helper(TreeNode node)
    {
        //if (node != null)
        //{
        //    return Math.Min(1 + MinDepth(node.left), 1 + MinDepth(node.right));
        //}
        if(node.left!=null)
        {
            depth = 1 + helper(node.left);
            height = Math.Min(height,depth);
       
        }
         if(node.right!=null)
        {
            depth = 1 + helper(node.right);
            height = Math.Min(height, depth);

        }
        else // both nodes are null
        {
            //height = Math.Min(height, depth);
            return 1;
        }
         return height;
  
    }
    return 100;

}
//Console.WriteLine("THE MINDEPTH METHOD :{0}",MinDepth(root));
int MinDepth(TreeNode root)
{
    //if (root.left != null && root.right != null)
    //{
    //    return Math.Min(1 + MinDepth(root.left), 1 + MinDepth(root.right));
    //}
    //else if (root.left == null && root.right != null)
    //{
    //    return 1 + MinDepth(root.right);
    //}
    //else if (root.right == null && root.left != null)
    //{
    //    return 1 + MinDepth(root.left);
    //}

    if(root==null) { return 0; }
    if (root.left != null && root.right != null) { return Math.Min(helper(root.left), helper(root.right)); }
    else if (root.right != null && root.left == null) { return helper(root.right); }
    else if(root.left != null && root.right == null){ return helper(root.left); }
    

    int helper(TreeNode node)
    {
        if (node != null)
        {
            return Math.Min(1 + MinDepth(node.left), 1 + MinDepth(node.right));
        }
        else
        {
            return 1;
        }
    }
    return 100;

}


//TreeNode five = new TreeNode(5);
//TreeNode four = new TreeNode(4);
//TreeNode eleven = new TreeNode(11);
//TreeNode seven = new TreeNode(7);
//TreeNode two = new TreeNode(2);
//TreeNode eight = new TreeNode(8);
//TreeNode thirteen = new TreeNode(13);
//TreeNode four2 = new TreeNode(4);
//TreeNode one = new TreeNode(1);

//five.left = four;
//five.right = eight;
//four.left = eleven;
//eleven.left = seven;
//eleven.right = two;
//eight.left = thirteen;
//eight.right = four2;
//four2.right = one;

//TreeNode one = new TreeNode(1);
//TreeNode two = new TreeNode(2);
//TreeNode three = new TreeNode(3);
//TreeNode four = new TreeNode(4);
//TreeNode five = new TreeNode(5);

//one.left = two;
//two.left = three;
//three.left = four;
//four.left = five;

//TreeNode node = null;

TreeNode five = new TreeNode(5);
TreeNode four = new TreeNode(4);
TreeNode eleven = new TreeNode(11);
TreeNode seven = new TreeNode(7);
TreeNode two = new TreeNode(2);
TreeNode eight = new TreeNode(8);
TreeNode thirteen = new TreeNode(13);
TreeNode four2 = new TreeNode(4);
TreeNode one = new TreeNode(1);


five.left = four;
five.right = eight;
four.left = eleven;
eleven.left = seven;
eleven.right = two;
eight.left = thirteen;
eight.right = four2;
four2.right = one;

Console.WriteLine(PathSum(five, 22));

 IList<IList<int>> PathSum(TreeNode root, int targetSum)
{

    if (root == null)// { return false; }
    {
        return null;
    }
   // IList<IList<object>> list4e = new List<IList<object>>();

      return (IList<IList<int>>)helper(root, targetSum);
  //  List<IList<int>> list = helper(root,targetSum);
   // return list;
    //return (IList<IList<int>>)list;

    IList helper(TreeNode root,int targetSum) // pravish go IList
    {
  
        if (root.left == null && root.right == null)
        {
            if ((targetSum - root.val) == 0)
            {
                // return true;
                
             //   List<List<int>> list = new List<List<int>>();
                List<int> list = new List<int>();
                list.Add(root.val);
               // list2.Add(root.val);
               // list.Add(list2);
                return list;
            }
            else
            {
                //  return false;
                return null;
            }            
        }
        //  bool L = false;
        //  bool R = false;
        //IList L = null;
        //IList R = null;

        IList L = null;
        IList R = null;
        if (root.left != null)
        {
            L = helper(root.left, targetSum - root.val);
        }
        if (root.right != null)
        {
            R = helper(root.right, targetSum - root.val);
        }
        //   return L || R;

        if (L != null && R != null)
        {
            //if (R != null)
            //{
                if (R.GetType() == typeof(List<List<int>>))
                {
                    foreach (var lis in (List<List<int>>)R)
                    {
                        lis.Add(root.val);
                    }
                }
                else
                {
                    R.Add(root.val);
                }
           // }

            //if (L != null)
            //{
                if (L.GetType() == typeof(List<List<int>>))
                {
                    foreach (var lis in (List<List<int>>)L)
                    {
                        lis.Add(root.val);
                    }
                }
                else
                {
                    L.Add(root.val);
                }
            //}
            List<List<int>> list = new List<List<int>>();
            list.Add((List<int>)L);
            list.Add((List<int>)R);
            return list;
          //  return new List<int> { L, R }; //  IList<IList
        }
        else if(L != null) 
        {
                if (L.GetType() == typeof(List<List<int>>))
                {
                    foreach (var lis in (List<List<int>>)L)
                    {
                        lis.Add(root.val);
                    }
                }
                else
                {
                    L.Add(root.val);
                }
            return L;
        }
        else if(R != null) 
        {
                if (R.GetType() == typeof(List<List<int>>))
                {
                    foreach (var lis in (List<List<int>>)R)
                    {
                        lis.Add(root.val);
                    }
                }
                else
                {
                    R.Add(root.val);
                }
                return R;
        }
        else 
        {
            return null;
        } // L and R are null
      //  return new List<TreeNode> { L, R };
    }
}


bool HasPathSum2(TreeNode root, int targetSum)
{
    if(root == null) { return false; }
    if(root.left == null && root.right == null)
    {
        if((targetSum-root.val) == 0 ) return true;
        return false;
    }
    bool L = false;
    bool R = false;
    if(root.left!=null)
    {
         L = HasPathSum2(root.left, targetSum-root.val);
    }
    if (root.right != null)
    {
         R = HasPathSum2(root.right, targetSum - root.val);
    }
    return L || R;


}



    bool HasPathSum(TreeNode root, int targetSum)
{
    if(root == null) { return false; }
    if (root.left != null && root.right != null)
    {
        return helper(root, targetSum);
    }
    else if (root.left != null)
    {
        return helper(root.left, targetSum-root.val);
    }
    else if (root.right != null)
    {
        return helper(root.right, targetSum-root.val);
    }
    else 
    {
        return helper(root, targetSum);
    }
    
    //bool L = helper(root.left, targetSum-root.val);
    //bool R = helper(root.right, targetSum - root.val);
    //if(L||R) { return true; }
   // return false;

    bool helper(TreeNode node, int targetSum)
    {
        if (node == null)
        {
            if (targetSum == 0) { return true; }
            else { return false; }
          
        }
        bool L = helper(node.left, targetSum - node.val);
        bool R = helper(node.right, targetSum - node.val);
        return L || R;
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