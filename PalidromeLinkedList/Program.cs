

ListNode node1 = new ListNode(1);
ListNode node2 = new ListNode(2);
ListNode node3 = new ListNode(2);
ListNode node4 = new ListNode(1);

node1.next = node2;
node2.next = node3;
node3.next = node4;

Console.WriteLine(IsPalindrome(node1));


bool IsPalindrome(ListNode head)
{
    // read all , put them in a stack
    // move head , compare with stack .pop until middle
    Stack<int> stack = new Stack<int>();
    ListNode first = head;
    while(first != null)
    {
        stack.Push(first.val);
        first = first.next;
    }

    int middle = stack.Count/2;
    for (int i = 0; i <= middle; i++) 
    {
        if(head == null)
        {
            return false;
        }
        else
        {
            if (stack.Pop() != head.val)
            {
                return false;
            }
            head = head.next;
        }
   
    }

    return true;
}


 public class ListNode
{
     public int val;
     public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
       {
        this.val = val;
        this.next = next;
       }
 }

