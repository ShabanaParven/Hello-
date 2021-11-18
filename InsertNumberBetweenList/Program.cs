using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertNumberBetweenList
{
   public  class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("before adding");
            list.Add(56);
            //list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine("--------------");
            Console.WriteLine("After adding");
            list.InsertAtPerticularPosition(2, 30);
            list.Display();

            Console.ReadKey();
        }
    }
}
