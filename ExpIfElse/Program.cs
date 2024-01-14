// See https://aka.ms/new-console-template for more information


List<int>? L = null;
List<int> R = new List<int>();

        if(L?.Any() ?? false)
        {
            Console.WriteLine("The L list is not null");
        }
        else
        {
            Console.WriteLine("The L list is  null");
        }

        if((R?.Any() ?? false))
        {
           Console.WriteLine("The  R list is not null");
}
else
{
    Console.WriteLine("THe R is null");
}





