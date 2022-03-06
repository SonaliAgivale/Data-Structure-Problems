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
            StackLinkedList stackLinkedList = new StackLinkedList();
            stackLinkedList.Push(56);
            stackLinkedList.Push(30);
            stackLinkedList.Push(70);
            Console.WriteLine("******* After Adding *******");
            stackLinkedList.Display();
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            stackLinkedList.Push();
            stackLinkedList.Pop();
            stackLinkedList.IsEmpty();  
            stackLinkedList.Display();
            Console.ReadLine();
        }
    }
}
