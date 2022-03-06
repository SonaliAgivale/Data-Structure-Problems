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
            list.Add(30);
            list.Append(56);  
            list.Append(70);
            int pos = list.Update(30);
            list.Insert(pos + 1, 40);
            Console.WriteLine("****** Orderd List *******");
            list.Size();
            list.Display();
            Console.ReadLine();

        }
    }
}
