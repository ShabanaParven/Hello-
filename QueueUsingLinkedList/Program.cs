using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue list = new LinkedListQueue();
            list.Enqueue(56);
            list.Enqueue(30);
            list.Enqueue(70);
            list.Display();

            Console.ReadKey();
        }
    }
}
