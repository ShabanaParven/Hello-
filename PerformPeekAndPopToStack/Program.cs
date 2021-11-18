using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformPeekAndPopToStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack list = new Stack();
            list.Push(70);
            list.Push(30);
            list.Push(56);
            list.Display();
            list.Peek();
            list.Pop();
            list.Display();
            list.IsEmpty();
            list.Display();
            Console.ReadKey();
        }
    }
}
