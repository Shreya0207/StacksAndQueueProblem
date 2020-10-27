using System;

namespace StackAndQueueProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stack and Queue Program");
            LinkedList list = new LinkedList();
            list.Push(70);
            list.Push(30);
            list.Push(56);
            list.Display();
            list.IsEmpty();
        }
    }
}
