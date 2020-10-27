using System;

namespace StackAndQueueProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stack and Queue Program");
            LinkedList list = new LinkedList();
            list.Enqueue(56);
            list.Enqueue(30);
            list.Enqueue(70);
            list.Dequeue();
            list.Display();
        }
    }
}
