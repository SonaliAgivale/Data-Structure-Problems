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
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Console.WriteLine("********* Adding At Bigining **********");
            list.Display();
            Console.ReadLine();

        }
    }
}
