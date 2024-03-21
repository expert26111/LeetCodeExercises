using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class MyStack
    {
        Queue<int> queue1 = new Queue<int>();
        Queue<int> queue2 = new Queue<int>();
        public MyStack()
        {
           
        }

        public void Push(int x)
        {
            queue1.Enqueue(x);
      
        }

        public int Pop()
        {
            int count = queue1.Count;
            if(count == 0 && count == 0)
            {
                throw new Exception("Trying to pop from an Empty Stack");
            }
            int el = 0;
            while(count > 1)
            {
                el = queue1.Dequeue();
                queue2.Enqueue( el );
                count--;
            }
            el = queue1.Dequeue();

            (queue2,queue1) = (queue1, queue2);
            return el;
        }

        public int Top()
        {
            int count = queue1.Count;
            if (queue1.Count == 0 && queue2.Count == 0)
            {
                throw new Exception("Trying to top from an Empty Stack");
            }

            if (count == 0 && count == 0)
            {
                throw new Exception("Trying to top from an Empty Stack");
            }
            int el = 0;
            while (count > 0)
            {
                el = queue1.Dequeue();
                queue2.Enqueue(el);
                count--;
            }

            (queue2, queue1) = (queue1, queue2);
            return el;
        }

        public bool Empty()
        {
            return queue1.Count == 0;
        }
    }
}
