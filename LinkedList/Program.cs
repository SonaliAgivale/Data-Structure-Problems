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
            Console.WriteLine("********* List on Node **********");
            list.Insert(1, 30);
            list.Display();
            //Remove 1st Element
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("Insert 40 after 30");
            int pos = list.Update(30);
            list.Insert(pos + 1, 40);
            Console.WriteLine("******* After adding ********");
            list.Display();
            Console.ReadLine();

        }
    }
}
