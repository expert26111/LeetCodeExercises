

using System.Net.Http.Headers;

Queue<int> q = new Queue<int>();
q.Enqueue(1);
q.Enqueue(2);
q.Enqueue(3);
q.Enqueue(4);
q.Enqueue(5);

q.Enqueue(q.Dequeue());

for(int i = 0;q.Count> 0;i++)
{
    Console.WriteLine("The element is {0} ",q.Dequeue());
}



