using System;
using System.Collections.Generic;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {

            // STack 
            var nameStack = new Stack<string>();

            nameStack.Push("James");
            nameStack.Push("Rob");
            var name = nameStack.Pop();

            Console.WriteLine(nameStack.Peek());


            var sOS = new Queue<string>();

            sOS.Enqueue("James");
            sOS.Enqueue("Rob");
            var currentCustomer = sOS.Dequeue();

            Console.WriteLine(sOS.Peek());
        }
    }
}
