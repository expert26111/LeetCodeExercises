

using System.Text;

string bla = "abbaca";
string bla1 = "azxxzy";
string bla2 = "aaaaaaaa";

Console.WriteLine(RemoveDuplicates2(bla));


string RemoveDuplicates2(string s)
{
    char[] charArr = s.ToCharArray();
    Stack<char> stack = new Stack<char>();
    for(int i = 0; i < charArr.Length; i++)
    {
        if(stack.Count == 0)
        {
            stack.Push(charArr[i]);
            continue;
        }
        if(stack.Peek() == charArr[i]) { stack.Pop(); continue; }
        if(stack.Peek() != charArr[i]) { stack.Push(charArr[i]); }
    }

    char[] array = new char[stack.Count];
    int index = 0;
    while(stack.Count > 0)
    {
        array[index] = stack.Pop();
        index++;
    }
    Array.Reverse(array);
    return new string(array);
}







    string RemoveDuplicates(string s)
{
    var local_string = s;
    char[] charArr = s.ToCharArray();
    Stack<char> stack = new Stack<char>();
  //  stack.Push(charArr[0]);
    int index = 0;
    string result = raads(charArr, local_string, index);
    return result;
    string raads(char[] array, string duma, int index)
    {
        if(string.IsNullOrWhiteSpace(duma))
        {
            return "";
        }
        stack.Push(array[0]);
        index++;
        while ( index < array.Length  )
        {

            //if(stack.Count == 0) { stack.Push(array[index]); index++; }
            if(index < array.Length && stack.Peek() != array[index])
            {
                stack.Push(array[index]);
                index++;
            }
            else if(stack.Peek() == array[index])
            {
                stack.Pop();
             //   if(index<array.Length) { index++; }
                string newDuma = duma.Substring(0, index - 1) + duma.Substring(index+1); // before and including the index
                array = newDuma.ToCharArray();
               // stack.Clear();
               // return raads(newDuma.ToCharArray(), newDuma, index = 0);
            }   
        }
        StringBuilder myStringBuilder = new StringBuilder();
        while( stack.Count > 0 ) 
        { 
            myStringBuilder.Append( stack.Pop() );
        }
        return myStringBuilder.ToString();


        //if(array.Length > 0) 
        //{
        //    string convertedToString = new string(array);
        //    return convertedToString;
        //}
        //else
        //{
        //    return  "";
        //}
    }
}