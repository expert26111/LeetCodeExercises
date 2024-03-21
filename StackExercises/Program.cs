


using System.Collections;
using System.Xml;

bool IsValid(string s)
{
    char[] chars = s.ToCharArray();
    Stack<char> stack = new Stack<char>();
    for(int i = 0; i < chars.Length; i++)
    {
       if( chars[i] == '(' )
        {
            stack.Push( ')' );
        }else if (chars[i] == '{')
        {
            stack.Push('}');
        }else if(chars[i] == '[')
        {
            stack.Push(']');
        }   
        else if(  stack.Count == 0 || stack.Pop() != chars[i] )
        {
            return false;
        }
    }
    if ( stack.Count == 0) {  return true; }
    return false;

}