using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            Console.WriteLine();
            list.Append(56);  
            list.Append(70);
            Console.WriteLine("********* Adding 30 between 56 and 70 **********");
            list.Insert(1, 30);
            list.Display();
            //Remove 1st Element
            Console.WriteLine();
            Console.WriteLine("****** Remove Last Node *******");
            list.RemovaLastNode();
            list.Display();
            Console.ReadLine();

        }
    }
}
