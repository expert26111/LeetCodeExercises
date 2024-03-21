
using System.Reflection.Metadata.Ecma335;
using System.Windows.Markup;
using System.Xml.Linq;



TreeNode InsertIntoBST(TreeNode root, int val)
{
   return helper(root, val);
  //  return root;
    TreeNode helper(TreeNode node, int val)
    {    
            if(node ==  null)
            {
                return new TreeNode(val);
            }
            if(node.val > val)
            {
               node.right = helper(node.left,val);
            }
            else
            {
               node.left =  helper(node.right,val);
            }
            return node;
    }
}






TreeNode prev = null;
void Flatten(TreeNode root)
{
    if (root == null)
        return;
    Flatten(root.right);
    Flatten(root.left);
    root.right = prev;
    root.left = null;
    prev = root;
}

TreeNode left = new TreeNode(0);
TreeNode three = new TreeNode(3);
TreeNode right = new TreeNode(0);

three.left = left;
three.right = right;    


//Console.WriteLine(DistributeCoins(three));


 int DistributeCoins(TreeNode root)
{
    int answer = 0;
    helper(root);
    return answer;
    int helper(TreeNode node)
    {
        
        if(node == null)
        {
            return 0;
        }
        int coin = helper(node.left) + helper(node.right) + node.val - 1;
        answer = answer + Math.Abs(coin);
        return coin;

    }
}






//TreeNode nine = new TreeNode(9);
//TreeNode three = new TreeNode(3);
//TreeNode twenty = new TreeNode(20);
//TreeNode fifteen = new TreeNode(15);
//TreeNode seven = new TreeNode(7);


//three.left = nine;
//three.right = twenty;
//twenty.left = fifteen;
//twenty.right = seven;

//int theSum = SumOfLeftLeaves(three);

//Console.WriteLine(theSum);

int SumOfLeftLeaves(TreeNode root)
{

    if(root.left == null && root.right == null)
    {
        return 0;
    }
    int totalSum = 0;
    return  traverse(root, true);
    int traverse(TreeNode node, bool value)
    {
        if(node.left == null && node.right == null && value)
        {
            return totalSum += node.val;
        }
        if (node.left != null)
        {
            totalSum = 0 + traverse(node.left, true);
        }
        if(node.right != null) 
        {
            totalSum = 0 + traverse(node.right, false);
        }
        return totalSum;
    }
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

//TreeNode one = new TreeNode(1);
//TreeNode two = new TreeNode(2);
//TreeNode three = new TreeNode(3);
//TreeNode four = new TreeNode(4);
//TreeNode five = new TreeNode(5);
//TreeNode six = new TreeNode(6);
//TreeNode seven = new TreeNode(7);

//five.left = three;
//five.right = six;
//three.left = two;
//three.right = four;
//six.right = seven;

//DeleteNode(five, 3);

//IList<int> list = InorderTraversal(five);
//foreach (int chislo in list)
//{
//    Console.WriteLine(chislo);
//}

TreeNode DeleteNode(TreeNode root, int key)
{
    int searchValue = key;
    TreeNode val = traverse(root);
    return val;

    TreeNode traverse(TreeNode node )
    {
        if (node == null)
        {
            return null;
        }

         node.right = traverse(node.right);

         node.left = traverse(node.left);

        if(node.val == searchValue) 
        {
           if(node.right == null && node.left == null)
            {
                return null;
            }
            else if(node.right == null && node.left != null)
            {
                return node.left;
            }else if(node.left == null && node.right != null)
            {
                return node.right;
            }
            else
            {
                deleteNodeInTree(node.left, node.right);
            }
            return node.right;
        }
        else
        {
            return node;
        }

      void  deleteNodeInTree( TreeNode left, TreeNode right)
            {
                 while(right.left != null) 
                    { 
                         right = right.left;
                    }
                 right.left = left;
            }
    }
}




//TreeNode node = DeleteNode(five,3);
//Console.WriteLine(num);

//TreeNode DeleteNode(TreeNode root, int key)
//{
//    return DeleteNodeHelper(root, key);
//}

// TreeNode DeleteNodeHelper(TreeNode node, int key)
//{
//    if (node == null)
//        return null;

//    node.left = DeleteNodeHelper(node.left, key);
//    node.right = DeleteNodeHelper(node.right, key);

//    if (node.val != key)
//        return node;

//    if (node.right == null)
//        return node.left;

//    if (node.left == null)
//        return node.right;

//    return MoveLeftToRight(node);
//}

 TreeNode MoveLeftToRight(TreeNode node)
{
    TreeNode left = node.left;
    TreeNode baseRight = node.right;
    TreeNode right = node.right;

    while (right.left != null)
        right = right.left;

    right.left = left;
    return baseRight;
}







//TreeNode one = new TreeNode(1);
//TreeNode two = new TreeNode(2);
//TreeNode three = new TreeNode(3);
//TreeNode four = new TreeNode(4);
//TreeNode five = new TreeNode(5);

//one.right = three;
//one.left = two;
//two.left = four;
//two.right = five;

//int num = DiameterOfBinaryTree(one);
//Console.WriteLine(num);

int DiameterOfBinaryTree(TreeNode root)
{
    if(root == null) return 0;
    int max = int.MinValue;
    void deepest(TreeNode node, int chislo)
    {
        if (node != null) { chislo++; deepest(node.left, chislo); deepest(node.right, chislo); }
        if(node == null) { if (chislo > max) { max = chislo; } }
    }

    int chislo = 0;
    int L = 0;
    if (root.left != null)
    {
        deepest(root.left, chislo);
        L = max;
    }
    else
    {
        L = 0;
    }
    chislo = 0;
    max = int.MinValue;
    int R = 0;
    if (root.right != null) { deepest(root.right, chislo); R = max; } else { R = 0; }
    return L + R;
}



//int[] array = FindMode(one);

int[] FindMode(TreeNode root)
{
    Dictionary<int,int> times = new Dictionary<int,int>();
    List<int> list = new List<int>();
    helper(root);
    void helper(TreeNode node)
    {
        if(node!=null)
        {         
            times[node.val] = times.GetValueOrDefault(node.val, 0) + 1;
            helper(node.left);
            helper(node.right);
        }
    }

    int max = times.Max(x => x.Value);
    foreach (KeyValuePair<int, int> entry in times)
    {
        if (entry.Value == max)
        {
            list.Add(entry.Key);
        }
    }
    return list.ToArray();
}







//TreeNode one = new TreeNode(1);
//TreeNode two = new TreeNode(2);
//TreeNode five = new TreeNode(5);
//TreeNode three = new TreeNode(3);

//one.left = two;
//one.right = three;
//two.right = five;


//IList<string> list = BinaryTreePaths(one);

//for(int i = 0; i < list.Count; i++)
//{
//    Console.WriteLine(i.ToString());
//}

 IList<string> BinaryTreePaths(TreeNode root)
{
    List<string> paths = new List<string>();

    string s = "";
    helper(root,s);
    return paths;

    void helper(TreeNode node, string s)
    {
          if(node.left == null && node.right == null)
            {
                    s += node.val.ToString();
                    paths.Add(s);
            }
          else if(node.left != null && node.right != null)
           {
            s += node.val + "->"; helper(node.left, s);
            helper(node.right, s);
           }
       else if (node.left != null && node.right == null)
        {
            s += node.val + "->"; helper(node.left, s);
        }
       else if (node.left == null && node.right != null)
        {
            s += node.val + "->"; helper(node.right, s);
        }

    }
}




TreeNode InvertTree(TreeNode root)
{
    if (root == null) { return root; }
    InvertHelper(root);
    return root;

    void InvertHelper(TreeNode node)
        {
            if(node == null) { return; }
            TreeNode temp = node.left;
            node.left = node.right;
            node.right = temp;

            InvertHelper(node.right);
            InvertHelper(node.left);
         }
}

int CountNodes(TreeNode root)
{
    if (root == null) {  return 0; }
    if(root.right == null && root.left == null)
    {
        return 1;
    }
    else
    {
        return 1+ CountNodes(root.left) + CountNodes(root.right);
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
