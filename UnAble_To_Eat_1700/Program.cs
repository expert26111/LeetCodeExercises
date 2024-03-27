




int[] students = [1, 1, 1, 0, 0, 1];
int[] sandwitches = [1, 0, 0, 0, 1, 1];

int result = CountStudents(students, sandwitches);
Console.WriteLine("The result is "+result);

int CountStudents(int[] students, int[] sandwiches)
{
    Queue<int> stack = new Queue<int>(sandwiches);
    Queue<int> queue = new Queue<int>(students);
    int counter = 0;
    while(stack.Count > 0 && counter < stack.Count)
    {
            if (queue.Peek() == stack.Peek())
            {
                queue.Dequeue();
                stack.Dequeue();
                counter = 0;
            }
            else
            {
                int number = queue.Dequeue();
                queue.Enqueue(number);
                counter++;
            }
    }
    return stack.Count;
}  

    //for (int i = 0; i < sandwiches.Length; i++)
    //{
    //    if (students[i] == stack.Peek())
    //    {
    //        stack.Pop();
    //        queue.Dequeue();
    //          continue;
    //    }
    //    else
    //    {
    //        queue.Enqueue(students[i]);
    //        continue;
    //    }
    //}

    //if(queue.Count == 0)
    //{
    //    return 0;
    //}


  //   int maxNumberOfStudents = students.Length;
  //   Queue<int> queueStudent = new Queue<int>(students);
  /////  Queue<int> queueStudent2 = new Queue<int>();

  //  int sadwitchIndex = 0;
  //  for (int i = 0;i<students.Length;i++)
  //  {

  //      if (queueStudent.Peek() == sandwiches[sadwitchIndex])
  //      {
  //          queueStudent.Dequeue();
  //          sadwitchIndex++;
  //          counter++;
  //      }
  //  }


    //int counter = 0;

    // if(queueStudent.Peek() == sandwiches[sadwitchIndex])
    //  {
    //      queueStudent.Dequeue();
    //      sadwitchIndex++;
    //      counter++;
    //}
    //else
    //{
    //    queueStudent.Dequeue();
    //    queueStudent.Enqueue(counter);
    //}






