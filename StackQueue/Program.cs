using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueLinkedList linkedListQueue = new QueueLinkedList();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            Console.WriteLine("------Queue List------");
            linkedListQueue.Display();
            Console.ReadLine();
        }
    }
}
